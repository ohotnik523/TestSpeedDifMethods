namespace Ilja_ParserHTML;

public class Utils
{
    public static string getAttrValue(string src, string tag, string attr)
    {
        src = src.Trim();
        if (!string.IsNullOrEmpty(src))
        {
            tag = "<" + tag + " ";
            if (src.Contains(tag))
            {
                attr = " " + attr + "=\"";
                int attrPos = src.IndexOf(attr);
                if (attrPos != -1)
                {
                    int qtyCharBeforeAttrValue = attrPos + attr.Length;
                    int qtyCharBeforeValueEnd = src.IndexOf("\"", qtyCharBeforeAttrValue);
                    return src.Substring(qtyCharBeforeAttrValue, (qtyCharBeforeValueEnd - qtyCharBeforeAttrValue));
                }
            }
        }
        return null;
    }
    public static string getAttrValueWithConditions(string src, string tag, string attrCond, string valueOfAttrCond,
        string attrSearch)
    {
        src = src.Trim();
        if (!String.IsNullOrEmpty(src))
        {
            tag = "<" + tag + " ";
            attrCond = attrCond + "=\"";
            valueOfAttrCond = "\"" + valueOfAttrCond + "\"";
            if (src.Contains(tag) && src.Contains(attrCond) && src.Contains(valueOfAttrCond))
            {
                attrSearch = " " + attrSearch + "=\"";
                int attrSearchPos = src.IndexOf(attrSearch);
                if (attrSearchPos != -1)
                {
                    int qtyCharBeforeAttrSearchValue = attrSearchPos + attrSearch.Length;
                    int qtyCharBeforeValueSearchEnd = src.IndexOf("\"", qtyCharBeforeAttrSearchValue);
                    return src.Substring(qtyCharBeforeAttrSearchValue, (qtyCharBeforeValueSearchEnd - qtyCharBeforeAttrSearchValue));
                }
            }
        }
        return null;
    }
}
