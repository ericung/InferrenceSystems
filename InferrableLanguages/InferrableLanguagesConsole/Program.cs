﻿string x1 = "abaababa";
string y1 = "abaab";
string z1 = "aba";
string x2 = "ab";
string y2 = "a";
string z2 = "b";

Console.WriteLine(InferrableLanguages.InferrableLanguages.LHSx1(y1, z2, x2, y2, z1));
Console.WriteLine(InferrableLanguages.InferrableLanguages.LHSy1(z2, x2, y2, z1, x1));
Console.WriteLine(InferrableLanguages.InferrableLanguages.LHSz1(x2, y2, z1, x1, y1));