﻿namespace T4Editor
{
    public class RegEx
    {
        public string statementBlockRegex = "(?<!\")<#((?!\"|=|@|\\+))((?!(?!)<#(?!\\+|\\=)|#>)[\\s|\\w|\\d|\n|().,<>\\-:;@#$%^&=*\\[\\]\"'+\\/\\\\®°⁰!?{}|`~])*(?=\\s?|\\w?|\n?)(?<!\")#>(?!\")";
        public string outputRegex = "(?<=#>)(((?!<#(?!\\+|\\=|\")|#>(?!\"))[\\s|\\w|\\d|\n|().,<>\\-:;@#$%^&=*\\[\\]\"'+\\/\\\\®°⁰!?{}|`~])*(?=\\s|\\w|\\n?))(?=<#)";
        public string classFeatureBlockRegex = "<#\\+((?!<#(?!\\+|\\=)|#>)[\\s|\\w|\\d|\n|().,<>\\-:;@#$%^&=*\\[\\]\"'+\\/\\\\®°⁰!?{}|`~])*(?=\\s|\\w|\\n?)#>";
        public string directiveRegex = "(?<=<#@)((?!<#(?!\\+|\\=)|#>)[\\s|\\w|\\d|\n|().,<>\\-:;@#$%^&=*\\[\\]\"'+\\/\\\\®°⁰!?{}|`~])*(?=\\s|\\w|\\n?)(?=#>)";
        public string injectedRegex = "<#=((?!<#(?!\\+|\\=)|#>)[\\s|\\w|\\d|\n|().,<>\\-:;@#$%^&=*\\[\\]\"'+\\/\\\\®°⁰!?{}|`~])*(\\s?)#>";
    }
}
