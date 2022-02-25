using System.Collections.Generic;
using System.Xml;

namespace IotDB_FunctionBlock_Creator
{
    internal enum VARTYPE
    {
        //变量类型枚举
        INPUT = 0,
        OUTPUT,
        MIDDLE
    }

    internal enum VARDATATYPE
    {
        //变量数据类型枚举
        BOOL = 0,
        SINT,
        INT,
        DINT,
        USINT,
        UINT,
        UDINT,
        REAL,
        TIME
    }

    internal class Vars
    {
        //变量类
        public int id;
        public string name;
        private VARDATATYPE datatype;
        public VARTYPE type;
        private string initvalue;
        private bool ispointer;

        public Vars(string varName, VARDATATYPE varDatatype, VARTYPE varType, string value, bool varispointer)
        {
            //构造函数
            id = 0;
            name = varName;
            datatype = varDatatype;
            type = varType;
            initvalue = value;
            ispointer = varispointer;
        }

        public XmlElement GetXmlElement(XmlDocument xd)
        {
            //获取xml化的元素
            XmlElement var;
            if (type == VARTYPE.INPUT)
            {
                var = xd.CreateElement("inputVAR");
                if (ispointer)
                {
                    var.SetAttribute("IsPointer", "True");
                }
                else
                {
                    var.SetAttribute("IsPointer", "False");
                }
                var.SetAttribute("InitValue", initvalue);
                XmlElement inputVARId = xd.CreateElement("inputVARId");
                inputVARId.InnerText = id.ToString();
                var.AppendChild(inputVARId);
                XmlElement inputVARName = xd.CreateElement("inputVARName");
                inputVARName.InnerText = name;
                var.AppendChild(inputVARName);
                XmlElement inputType = xd.CreateElement("inputType");
                inputType.InnerText = datatype.ToString();
                var.AppendChild(inputType);
                return var;
            }
            else if (type == VARTYPE.OUTPUT)
            {
                var = xd.CreateElement("outputVAR");
                if (ispointer)
                {
                    var.SetAttribute("IsPointer", "True");
                }
                else
                {
                    var.SetAttribute("IsPointer", "False");
                }
                var.SetAttribute("InitValue", initvalue);
                XmlElement outputVARId = xd.CreateElement("outputVARId");
                outputVARId.InnerText = id.ToString();
                var.AppendChild(outputVARId);
                XmlElement outputVARName = xd.CreateElement("outputVARName");
                outputVARName.InnerText = name;
                var.AppendChild(outputVARName);
                XmlElement outputType = xd.CreateElement("outputType");
                outputType.InnerText = datatype.ToString();
                var.AppendChild(outputType);
                return var;
            }
            else if (type == VARTYPE.MIDDLE)
            {
                var = xd.CreateElement("middleVAR");
                var.SetAttribute("InitValue", initvalue);
                XmlElement middleVARId = xd.CreateElement("middleVARId");
                middleVARId.InnerText = id.ToString();
                var.AppendChild(middleVARId);
                XmlElement middleVARName = xd.CreateElement("middleVARName");
                middleVARName.InnerText = name;
                var.AppendChild(middleVARName);
                XmlElement middleType = xd.CreateElement("middleType");
                middleType.InnerText = datatype.ToString();
                var.AppendChild(middleType);
                return var;
            }
            var = xd.CreateElement("error");
            return var;
        }
    }

    internal class FunctionBlock
    {
        //功能块类
        private string funcBlockName;
        public int id;
        private string ControlColor;
        private int ControlHeight;
        private int ControlWidth;
        private int ControlTime;
        private int PinLength;
        private int PinWidth;
        private string ControlName;
        private string codearea;
        private string ccode;
        private string picture;
        private string description;
        private List<Vars> fbVars;
        private int incount;
        private int outcount;
        private int midcount;

        public FunctionBlock(string name)
        {
            //构造函数
            funcBlockName = name;
            ControlColor = "LightBlue";
            ControlHeight = 72;
            ControlWidth = 150;
            ControlTime = 0;
            ControlName = "";
            codearea = "";
            ccode = "";
            picture = "iVBORw0KGgoAAAANSUhEUgAAABkAAAAZCAYAAADE6YVjAAAAAXNSR0IArs4c6QAAAARnQU1BAACx" +
                "jwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAABSSURBVEhL7c3BCgAgCANQ//+nC28eJjWNCNqDEZQ5kxN" +
                "GI9uo4eCDEn9AqUB7PFD6sED9u1riZxYku4eo4UAllDdKfCCmgtrRKdmmErqkGukwm/I4VqoxxJ6AAAAAAElFTkSuQmCC";
            description = "";
            PinLength = 16;
            PinWidth = 16;
            fbVars = new List<Vars>();
            incount = 0;
            outcount = 0;
            midcount = 0;
        }

        public int AddVar(Vars var)
        {
            //添加变量
            if (var.type == VARTYPE.INPUT)
            {
                var.id = incount;
                incount++;
            }
            else if (var.type == VARTYPE.OUTPUT)
            {
                var.id = outcount;
                outcount++;
            }
            else if (var.type == VARTYPE.MIDDLE)
            {
                var.id = midcount;
                midcount++;
            }
            else
            {
                return -1;
            }
            fbVars.Add(var);
            return 1;
        }

        public void AddCode(string codearea, string ccode)
        {
            //添加代码
            this.codearea = codearea;
            this.ccode = ccode;
        }

        public void AddDescription(string description)
        {
            //添加描述
            this.description = description;
        }

        public void SetCodeArea()
        {
            //获取codearea字符串
            string ca = " FBD";
            ca += funcBlockName;
            ca += " NAME";
            foreach (var v in fbVars)
            {
                ca += ",";
                ca += v.name;
            }
            ca += " ";
            codearea = ca;
        }

        public void SetCCode(string define,string code)
        {
            //获取ccode字符串
            string cc = "FBD";
            cc += funcBlockName;
            cc += "(ePLCKernalSta *Task, Uint32 FBIndex,struct " + funcBlockName + " *FB){";
            cc += define + " /*Separator--*--Separator--*--Separator*/ ";
            cc += code + "}";
            ccode = cc;
        }

        public XmlElement GetXmlElement(XmlDocument xd)
        {
            //避免空字符串
            if (codearea == "")
                SetCodeArea();
            if (ccode == "")
                SetCCode("", "");
            //获取xml化的功能块
            XmlElement funcblock = xd.CreateElement("usercontroltype");
            funcblock.SetAttribute("type", "IotDB");
            funcblock.SetAttribute("codeType", "C");
            funcblock.SetAttribute("FuncOrFuncBlock", "FuncBlock");
            XmlElement ID = xd.CreateElement("Id");
            ID.InnerText = id.ToString();
            funcblock.AppendChild(ID);
            XmlElement cc = xd.CreateElement("ControlColor");
            cc.InnerText = ControlColor;
            funcblock.AppendChild(cc);
            XmlElement ch = xd.CreateElement("ControlHeight");
            ch.InnerText = ControlHeight.ToString();
            funcblock.AppendChild(ch);
            XmlElement cw = xd.CreateElement("ControlWidth");
            cw.InnerText = ControlWidth.ToString();
            funcblock.AppendChild(cw);
            XmlElement pl = xd.CreateElement("PinLength");
            pl.InnerText = PinLength.ToString();
            funcblock.AppendChild(pl);
            XmlElement cn = xd.CreateElement("ControlName");
            if (ControlName != "")
                cn.InnerText = ControlName;
            funcblock.AppendChild(cn);
            XmlElement un = xd.CreateElement("UserdefinedName");
            un.InnerText = funcBlockName;
            funcblock.AppendChild(un);
            //xml变量添加
            XmlElement inputvar = xd.CreateElement("InputVars");
            XmlElement inputc = xd.CreateElement("number");
            inputc.InnerText = incount.ToString();
            inputvar.AppendChild(inputc);
            XmlElement outputvar = xd.CreateElement("OutputVars");
            XmlElement outputc = xd.CreateElement("number");
            outputc.InnerText = outcount.ToString();
            outputvar.AppendChild(outputc);
            XmlElement middlevar = xd.CreateElement("MiddleVars");
            XmlElement middlec = xd.CreateElement("number");
            middlec.InnerText = midcount.ToString();
            middlevar.AppendChild(middlec);
            foreach (var v in fbVars)
            {
                XmlElement vtemp = v.GetXmlElement(xd);
                if (v.type == VARTYPE.INPUT)
                {
                    inputvar.AppendChild(vtemp);
                }
                else if (v.type == VARTYPE.OUTPUT)
                {
                    outputvar.AppendChild(vtemp);
                }
                else if (v.type == VARTYPE.MIDDLE)
                {
                    middlevar.AppendChild(vtemp);
                }
            }
            funcblock.AppendChild(inputvar);
            funcblock.AppendChild(outputvar);
            funcblock.AppendChild(middlevar);
            XmlElement ca = xd.CreateElement("codearea");
            ca.InnerText = codearea;
            funcblock.AppendChild(ca);
            XmlElement cco = xd.CreateElement("ccode");
            cco.InnerText = ccode;
            funcblock.AppendChild(cco);
            XmlElement pic = xd.CreateElement("Picture");
            pic.InnerText = picture;
            funcblock.AppendChild(pic);
            XmlElement des = xd.CreateElement("Discription");
            des.InnerText = description;
            funcblock.AppendChild(des);
            XmlElement pw = xd.CreateElement("PinWidth");
            pw.InnerText = PinWidth.ToString();
            funcblock.AppendChild(pw);
            XmlElement ct = xd.CreateElement("ControlTime");
            ct.InnerText = ControlTime.ToString();
            funcblock.AppendChild(ct);
            return funcblock;
        }
    }

    internal class FunctionBlockGroup
    {
        //功能块组（工具箱）类
        private string name;
        private string chname;
        private List<FunctionBlock> funcBlocks;
        private int count;

        public FunctionBlockGroup(string name, string chname)
        {
            //构造函数
            this.name = name;
            this.chname = chname;
            funcBlocks = new List<FunctionBlock>();
            count = 1;
        }

        public void AddFuncBlock(FunctionBlock fb)
        {
            //添加功能块
            fb.id = count;
            funcBlocks.Add(fb);
            count++;
        }

        public int SaveAsXml(string path)
        {
            //导出xml文件
            XmlDocument xd = new XmlDocument();
            xd.AppendChild(xd.CreateXmlDeclaration("1.0", "", ""));
            XmlElement root = xd.CreateElement("USERCONTROLTYPE");
            xd.AppendChild(root);
            XmlElement group = xd.CreateElement(name);
            group.SetAttribute("ChName", chname);
            foreach (var fb in funcBlocks)
            {
                XmlElement fbtemp = fb.GetXmlElement(xd);
                group.AppendChild(fbtemp);
            }
            root.AppendChild(group);
            xd.Save(path);
            return 1;
        }
    }
}
