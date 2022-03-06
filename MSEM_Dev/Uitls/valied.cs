using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSEM_Dev.Uitls
{
    public static class Valied
    {
        public static bool isPhone(string phone)
        {
            if (phone.Length < 11)
            {
                return false;
            }
            //电信手机号码正则
            string dianxin = @"^1[3578][01379]\d{8}$";
            Regex regexDX = new Regex(dianxin);
            //联通手机号码正则
            string liantong = @"^1[34578][01256]\d{8}";
            Regex regexLT = new Regex(dianxin);
            //移动手机号码正则
            string yidong = @"^(1[012345678]\d{8}|1[345678][012356789]\d{8})$";
            Regex regexYD = new Regex(dianxin);
            if (regexDX.IsMatch(phone) || regexLT.IsMatch(phone) || regexYD.IsMatch(phone))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isTrueLen(string input,int MinLen,int MaxLen)
        {
            return input.Length > MinLen && input.Length < MaxLen;
        }
        public static bool isTrueNum(int input, int MinLen, int MaxLen)
        {
            return input > MinLen && input < MaxLen;
        }
    }
}
