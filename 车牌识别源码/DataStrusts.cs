using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;

namespace 车牌识别
{
    public enum PlateCategory
    {
        非字符 = 0,
        穗 = 1,
        A = 2,
        B = 3,
        C = 4,
        D = 5,
        E = 6,
        F = 7,
        G = 8,
        H = 9,
        I = 10,
        J = 11,
        K = 12,
        L = 13,
        M = 14,
        N = 15,
        O = 16,
        P = 17,
        Q = 18,
        R = 19,
        S = 20,
        T = 21,
        U = 22,
        V = 23,
        W = 24,
        X = 25,
        Y = 26,
        Z = 27,
        _0 = 28,
        _1 = 29,
        _2 = 30,
        _3 = 31,
        _4 = 32,
        _5 = 33,
        _6 = 34,
        _7 = 35,
        _8 = 36,
        _9 = 37,
        点 = 38,
        京 = 39,
        津 = 40,
        沪 = 41,
        渝 = 42,
        蒙 = 43,
        新 = 44,
        藏 = 45,
        宁 = 46,
        桂 = 47,
        港 = 48,
        澳 = 49,
        黑 = 50,
        吉 = 51,
        辽 = 52,
        晋 = 53,
        冀 = 54,
        青 = 55,
        鲁 = 56,
        豫 = 57,
        苏 = 58,
        皖 = 59,
        浙 = 60,
        闽 = 61,
        赣 = 62,
        湘 = 63,
        鄂 = 64,
        粤 = 65,
        琼 = 66,
        甘 = 67,
        陕 = 68,
        贵 = 69,
        云 = 70,
        川 = 71,
        警 = 72,
    }

    public class PlateInfo
    {
        //样品数据
        public Mat PlateMat;
        //标签
        public PlateCategory Category;

    }


    public class PlateCarInfo
    {
        //样品数据
        public Mat PlateMatCar;
        //标签
        public PlateCar CategoryCar;
    }

    public enum PlateCar
    {
        车牌 = 0,
        非车牌 = 1
    }

}
