using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nitrogen.Foundation;
using Nitrogen.Foundation.Extensions;
using Nitrogen.Foundation.Helper;

namespace Nitrogen.AzureCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly VerifyCodeHelper _verifyCodeHelper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(VerifyCodeHelper verifyCodeHelper, IHttpContextAccessor httpContextAccessor,UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _verifyCodeHelper = verifyCodeHelper;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CheckLogin(string username, string password, string verifycode, int autologin)
        {
            try
            {
                if (autologin == 0)
                {
                    verifycode = Md5Helper.Get16MD5One(verifycode.ToLower());
                    var codeSession = _httpContext.HttpContext.Session.GetString("session_verifycode");
                    if (codeSession.IsEmpty() || "\""+verifycode+"\"" != codeSession)
                    {
                        throw new Exception("验证码错误，请重新输入");
                    }
                }
                //var user = new IdentityUser { UserName = "Admin", Email = "1052231926@qq.com" };
                //var resultzz = await _userManager.CreateAsync(user, "Admin888.");
                // 登录操作
                var result = await _signInManager.PasswordSignInAsync(username, password, false, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    return Content("{ \"type\":1,\"errorcode\":0 ,\"message\": \"登录成功\",\"resultdata\":null }");
                }
                else {
                    return Content("{ \"type\":3,\"errorcode\":0 ,\"message\": \"账号密码有误\",\"resultdata\":null }");
                }

            }
            catch (Exception ex)
            {
                //{"type":3,"errorcode":0,"message":"验证码错误，请重新输入","resultdata":null}
                return Content("{ \"type\":3,\"errorcode\":0 ,\"message\": \"验证码错误，请重新输入\",\"resultdata\":null }");
            }
          

        }

        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult VerifyCode()
        {
           // HttpContext.Session.SetString("session_verifycode", Md5Helper.Get16MD5One("lz12".ToLower()));
            return File(_verifyCodeHelper.GetVerifyCode(), @"image/Gif");
        }
    }
}