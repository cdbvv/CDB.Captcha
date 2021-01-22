using CDB.Captcha;
using Microsoft.AspNetCore.Mvc;

namespace CaptchaDemo
{
    [Route("[controller]/[action]")]
    public class CaptchaController : ControllerBase
    {
        /// <summary>
        /// 泡泡中文验证码 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public object BubbleCode()
        {
            var ch = new CaptchaHelper();
            var code = ch.GetRandomCnText(2);
            var imgbyte = ch.GetBubbleCodeByte(code);
            return File(imgbyte, "image/png");
        }

        /// <summary>
        /// 数字字母组合验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public object HybridCode()
        {
            var ch = new CaptchaHelper();
            var code = ch.GetRandomEnDigitalText(4);
            var imgbyte = ch.GetEnDigitalCodeByte(code);
            return File(imgbyte, "image/png");
        }

        /// <summary>
        /// gif泡泡中文验证码 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public object GifBubbleCode()
        {
            var ch = new CaptchaHelper();
            var code = ch.GetRandomCnText(2);
            var imgbyte = ch.GetGifBubbleCodeByte(code);
            return File(imgbyte, "image/gif");
        }

        /// <summary>
        /// gif数字字母组合验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public object GifHybridCode()
        {
            var ch = new CaptchaHelper();
            var code = ch.GetRandomEnDigitalText(4);
            var imgbyte = ch.GetGifEnDigitalCodeByte(code);
            return File(imgbyte, "image/gif");
        }
    }
}
