namespace MovieDatabase.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Models.Identity;
    using Services.Identity;

    public class IdentityController : ApiController
    {
        private readonly IIdentityService identityService;
        private readonly ICurrentUserService currentUserService;

        public IdentityController(
            IIdentityService identity,
            ICurrentUserService currentUser)
        {
            this.identityService = identity;
            this.currentUserService = currentUser;
        }


        [HttpPost]
        [Route(nameof(Register))]
        public async Task<ActionResult> Register(UserInputModel input)
        {
            var result = await this.identityService.Register(input);

            if (!result.Succeeded)
            {
                return this.BadRequest(result.Errors);
            }

            return this.Ok();
        }

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<ActionResult<LoginOutputModel>> Login(UserInputModel input)
        {
            var result = await this.identityService.Login(input);

            if (!result.Succeeded)
            {
                return this.BadRequest(result.Errors);
            }

            var user = result.Data;

            return new LoginOutputModel(user.Token, user.UserId);
        }

        [HttpPut]
        [Authorize]
        [Route(nameof(ChangePassword))]
        public async Task<ActionResult> ChangePassword(ChangePasswordInputModel input)
            => await this.identityService
                    .ChangePassword(new ChangePasswordServiceModel
                    {
                        UserId = this.currentUserService.UserId,
                        CurrentPassword = input.CurrentPassword,
                        NewPassword = input.NewPassword
                    });
    }
}
