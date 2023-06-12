////    <link rel=preload as="font" crossorigin type="font/woff2" href="./templates/fhs-editorial/fonts/open-sans-v17-cyrillic-ext_latin-ext-regular.woff2">
////                        <a href="tel:+3725275272">+372 527 527 2</a>

////      <tag attr1="value" attr2="value" attr3="value">


//using Ilja_ParserHTML;

//string src = "                        <a href=\"tel:+3725275272\">+372 527 527 2</a>";
//string src2 = "src=\"<b><link rel=preload as=\"font\" crossorigin type=\"font/woff2\" href=\"./templates/fhs-editorial/fonts/open-sans-v17-cyrillic-ext_latin-ext-regular.woff2\">\"";

//string total = Utils.getAttrValue(src, "a", "href");
//Console.WriteLine(total);
//String total2 = Utils.getAttrValueWithConditions(src2, "link", "preload as", "font", "type");
//Console.WriteLine(total2);
//GC.Collect();

//// --------------------------------------

//LinkedList<int> list3 = new LinkedList<int>(); // 3 вид list
//list3.AddFirst(2);
//foreach (int value in list3)
//{

//    Console.Write(value + " -list3 ");
//}












































////using System.Text.RegularExpressions;

////string str = "Бык тупогуб, тупогубенький бычок," + "у быка губа бела тупа";
////string milo = "ohotnik523@mail.ru " + "%@yandex% " + "ohotnik523@gmail.com " + "ohotnik523@list.com " + " ohotnik523@mailto.plus";



////Regex regex = new Regex(@"\w*губ(\w*)");
////Regex regex2 = new Regex(@"[а-я]{5}");
////Regex regex3 = new Regex(@"[\w-\.]+@([\w-]+\.)+[\w-]{2,4}");
////MatchCollection matches = regex.Matches(str);
////if (matches.Count > 0)
////{
////    foreach (Match match in matches)
////    {
////        Console.Write(match.Value + " ");
////    }

////}
////Console.WriteLine();
////Console.WriteLine();
////MatchCollection matches2 = regex3.Matches(milo);
////if (matches2.Count > 0)
////{
////    foreach (Match match in matches2)
////    {
////        Console.Write(match.Value + " ");
////    }

////}