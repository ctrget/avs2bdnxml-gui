using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace avs2bdnxml_gui
{
        public class ASSFile
        {
            public ASS_Header Header { get; set; }
            public List<ASS_Style> Styles { get; set; }
            public List<ASS_Event> Events { get; set; }

            public ASSFile()
            {
                this.Header = new ASS_Header();
                this.Styles = new List<ASS_Style>();
                this.Events = new List<ASS_Event>();
            }

            public class ASS_Header
            {
                //标题 对脚本内容的简单描述
                public string Title { get; set; }
                //脚本原著 脚本的最初作者
                public string Original_Script { get; set; }
                //原译者 对话的最初翻译者
                public string Original_Translation { get; set; }
                //原始润稿人 脚本的原始编辑
                public string Original_Editing { get; set; }
                //原时间轴
                public string Original_Timing { get; set; }
                //脚本修订
                public string Script_Updated_By { get; set; }
                //详细修订资料
                public string Update_Details { get; set; }
                //脚本格式
                public string ScriptType { get; set; }
                //换行样式:定义默认换行样式
                //0: 智能换行，各行长短尽可能相等
                //1: 行末文字换行，只使用“\N”强制换行
                //2:不自动换行，“\n”“\N”都强制换行
                //3:和0相同，但较靠下的行比靠上的行长*/
                public string WrapStyle { get; set; }
                public string ScaledBorderAndShadow { get; set; }
                //同步点 描述执行脚本时应以视频文件的何处作为时间原点
                public string Synch_Point { get; set; }
                //碰撞处理 (Normal 标准) (Reverse 颠倒)
                public string Collisions { get; set; }
                //显示色深 脚本的作者执行脚本时使用的色深
                public string PlayDepth { get; set; }
                //脚本的作者执行脚本的影片的宽度  
                public string PlayResX { get; set; }
                //脚本的作者执行脚本的影片的高度
                public string PlayResY { get; set; }
                //	计时器：执行脚本时的计时器速度，单位1%
                public string Timer { get; set; }
            }

            public class ASS_Style
            {
                public ASS_Style(string name, string fontname, string fontsize, string primarycolour, string secondarycolour, string outlinecolour, string backcolour, string bold, string italic, string underline, string strikeout, string scalex, string scaley, string spacing, string angle, string borderstyle, string outline, string shadow, string alignment, string marginl, string marginr, string marginv, string encoding)
                {
                    this.Name = name; this.Fontname = fontname; this.Fontsize = fontsize; this.PrimaryColour = primarycolour;
                    this.SecondaryColour = secondarycolour; this.OutlineColour = outlinecolour; this.BackColour = backcolour; this.Bold = bold;
                    this.Italic = italic; this.Underline = underline; this.StrikeOut = strikeout; this.ScaleX = scalex;
                    this.ScaleY = scaley; this.Spacing = spacing; this.Angle = angle; this.BorderStyle = borderstyle;
                    this.Outline = outline; this.Shadow = shadow; this.Alignment = alignment; this.MarginL = marginl;
                    this.MarginR = marginr; this.MarginV = marginv; this.Encoding = encoding;
                }

                //名称 要定义的样式的名称
                public string Name { get; set; }
                //字体 Windows所使用的字体名
                public string Fontname { get; set; }
                //字号
                public string Fontsize { get; set; }
                //主颜色  长整形BGR（蓝-绿-红）值
                //各类颜色代码也包含了alphat通道的信息
                //十六进制记录的顺序为 AABBGGRR
                public string PrimaryColour { get; set; }
                //副颜色
                //当一行字幕为了防止和其他字幕重叠而被自动移开始，
                //为了以示区别就会显示出这种颜色。
                public string SecondaryColour { get; set; }
                //描边颜色
                //当一行字幕为了防止和其他字幕重叠而被自动移开始，
                //为了以示区于第一、第二颜色显示的字幕就会使用第三颜色。
                public string OutlineColour { get; set; }
                //背景颜色
                public string BackColour { get; set; }
                //加粗    -1 表示真  0 表示假
                public string Bold { get; set; }
                //倾斜    -1 表示真  0 表示假
                public string Italic { get; set; }
                //下划线  -1 表示真  0 表示假
                public string Underline { get; set; }
                //删除线  -1 表示真  0 表示假
                public string StrikeOut { get; set; }
                //水平标尺 描述文字的宽度  单位[%]
                public string ScaleX { get; set; }
                //竖直标尺 描述文字的高度  单位[%]
                public string ScaleY { get; set; }
                //	间距 字符之间的额外间隔 单位[像素]
                public string Spacing { get; set; }
                //角度 字幕行预先旋转过的角度
                //可以为浮点小数 单位[°]
                public string Angle { get; set; }
                //边框样式 1=描边 + 投下阴影  3=不透明方框
                public string BorderStyle { get; set; }
                //描边 如果BorderStyle为1
                //那么这个字段指定描边的宽度
                //以像素为单位。取值可以是 0、1、2、3或者4
                public string Outline { get; set; }
                //阴影 如果BorderStyle为，
                //那么这个字段指定投下的阴影的深度
                //以像素为单位 取值可以是 0、1、2、3或者4
                //投影时总是连同描边一起投影
                //如果没给出描边宽度SSA总是强制使用1像素的描边
                public string Shadow { get; set; }
                //对齐方式 这个字段设置在考虑到左/右屏幕边距后
                //字幕如何左右对齐 以及竖直放置的位置。
                //按照数字键盘的布局（1-3 居底字幕 4-6居中字幕 7-9居顶字幕）

                public string Alignment { get; set; }
                //左边距 这个字段以像素为单位 指定左边距
                //它是字幕的左边边界到影片的左侧边缘的距离
                public string MarginL { get; set; }
                //右边距 这个字段以像素为单位 指定右边距
                //它是字幕的右边边界到影片的右侧边缘的距离
                public string MarginR { get; set; }
                //垂直边距这个字段以像素为单位 指定垂直边距
                //对于一条居底字幕 这是从银幕底端算起的距离
                //对于一条居顶字幕 这是从银幕顶端算起的距离
                //对于一条居中字幕 这个值将被忽略 文本永远垂直居中
                public string MarginV { get; set; }
                //编码 这个字段指定文本使用的编码字符集 以使用多语种Windows环境
                //对于英文(Western, ANSI)字幕它通常为0
                public string Encoding { get; set; }

            }

            public class ASS_Event
            {
                public ASS_Event(string layer, string start, string end, string style, string name, string marginl, string marginr, string marginv, string effect, string text)
                {
                    this.Layer = layer; this.Start = start; this.End = end; this.Style = style; this.Name = name;
                    this.MarginL = marginl; this.MarginR = marginr; this.MarginV = marginv; this.Effect = effect; this.Text = text;
                }

                //层 (任意整数)
                //处理字幕重叠时 所在层数不同的字幕认为不重叠
                //这个数值高的层会覆盖在数值低的层的上方
                public string Layer { get; set; }
                //起始时刻 写成 0:00:00:00 的格式
                //即 小时:分:秒:百分之一秒
                public string Start { get; set; }
                //终止时刻
                public string End { get; set; }
                //样式名称
                public string Style { get; set; }
                //角色姓名
                public string Name { get; set; }
                //左边距
                //左边距替换值 四位数字
                //这个字段以像素为单位
                //四位全为零表示按照你在Style字段中
                //选用的样式中给出的默认值
                public string MarginL { get; set; }
                //右边距
                public string MarginR { get; set; }
                //垂直边距
                public string MarginV { get; set; }
                //特效
                public string Effect { get; set; }
                //字幕文本
                public string Text { get; set; }
            }

 
        }

}
