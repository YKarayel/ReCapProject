using Azure.Core;
using Core.Utilities.Results;
using Entities.Concreate;
using Entities.DTOs;
using Core.Utilities.Security.JWT;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessToken = Core.Utilities.Security.JWT.AccessToken;

namespace Business.Abstract
{
	public interface IAuthService
	{
		IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
		IDataResult<User> Login(UserForLoginDto userForLoginDto);
		IResult UserExists(string email);
		IDataResult<AccessToken> CreateAccessToken(User user);
	}
}
