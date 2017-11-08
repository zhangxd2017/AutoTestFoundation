using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestFoundation.Constant
{
    enum MouseDirection
    {
        Herizontal,//水平方向拖动，只改变窗体的宽度        
        Vertical,//垂直方向拖动，只改变窗体的高度 
        Declining,//倾斜方向，同时改变窗体的宽度和高度        
        None//不做标志，即不拖动窗体改变大小 
    }
}
