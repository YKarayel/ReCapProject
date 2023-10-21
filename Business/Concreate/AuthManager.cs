using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
	public class AuthManager : IAuthService
	{
		private IUserManager _userManager;
		private ITokenHelper _tokenHelper;

		public AuthManager(ITokenHelper tokenHelper, IUserManager userManager)
		{

			_tokenHelper = tokenHelper;
			_userManager = userManager;
		}

		public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
		{
			byte[] passwordHash, passwordSalt;
			HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
			var user = new User
			{
				Email = userForRegisterDto.Email,
				FirstName = userForRegisterDto.FirstName,
				LastName = userForRegisterDto.LastName,
				PasswordHash = passwordHash,
				PasswordSalt = passwordSalt,
				Status = true
			};
			_userManager.Add(user);
			return new SuccessDataResult<User>(user,"Kayıt oldu");
		}

		public IDataResult<User> Login(UserForLoginDto userForLoginDto)
		{
			var userToCheck = _userManager.GetByMail(userForLoginDto.Email);
			if (userToCheck == null)
			{
				return new ErrorDataResult<User>("Kullanıcı bulunamadı");
			}

			if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
			{
				return new ErrorDataResult<User>("Parola Hatası");
			}

			return new SuccessDataResult<User>(userToCheck, "Başarılı Giriş");
		}

		public IResult UserExists(string email)
		{
			if (_userManager.GetByMail(email) != null)
			{
				return new ErrorResult("kullanıcı mevcut");
			}
			return new SuccessResult();
		}

		public IDataResult<AccessToken> CreateAccessToken(User user)
		{
			var claims = _userManager.GetClaims(user);
			var accessToken = _tokenHelper.CreateToken(user, claims);
			return new SuccessDataResult<AccessToken>(accessToken, "");
		}
	}
}
