using System;
using BAUERGROUP.Shared.Business.Models.ERP.Extensions;
using System.Globalization;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPLanguage
    {        
        public ERPLanguage(String sName, String sISO2, String sISO3)
        {
            Name = sName;
            ISO2 = sISO2;
            ISO3 = sISO3;
        }

        public ERPLanguage(ERPLanguage oERPLanguage)
        {
            Name = oERPLanguage.Name;
            ISO2 = oERPLanguage.ISO2;
            ISO3 = oERPLanguage.ISO3;
        }

        public ERPLanguage() :
            this (German)
        {

        }

        public String Name { get; set; }

        public String ISO2 { get; set; }
        public String ISO3 { get; set; }

        //Special Definitions
        public readonly static ERPLanguage Invariant = CultureInfo.InvariantCulture.FromCultureInfo();
        public readonly static ERPLanguage Current = CultureInfo.CurrentCulture.FromCultureInfo();

        //Static Definitions - Primary        
        public readonly static ERPLanguage German = new ERPLanguage("German", "de", "deu");
        public readonly static ERPLanguage English = new ERPLanguage("English", "en", "eng");

        //Static Definitions - Secondary
        public readonly static ERPLanguage Afar = new ERPLanguage("Afar", "aa", "aar");
        public readonly static ERPLanguage Abkhazian = new ERPLanguage("Abkhazian", "ab", "abk");
        public readonly static ERPLanguage Afrikaans = new ERPLanguage("Afrikaans", "af", "afr");
        public readonly static ERPLanguage Akan = new ERPLanguage("Akan", "ak", "aka");
        public readonly static ERPLanguage Amharic = new ERPLanguage("Amharic", "am", "amh");
        public readonly static ERPLanguage Arabic = new ERPLanguage("Arabic", "ar", "ara");
        public readonly static ERPLanguage Aragonese = new ERPLanguage("Aragonese", "an", "arg");
        public readonly static ERPLanguage Assamese = new ERPLanguage("Assamese", "as", "asm");
        public readonly static ERPLanguage Avaric = new ERPLanguage("Avaric", "av", "ava");
        public readonly static ERPLanguage Aymara = new ERPLanguage("Aymara", "ay", "aym");
        public readonly static ERPLanguage Azerbaijani = new ERPLanguage("Azerbaijani", "az", "aze");
        public readonly static ERPLanguage Bashkir = new ERPLanguage("Bashkir", "ba", "bak");
        public readonly static ERPLanguage Bambara = new ERPLanguage("Bambara", "bm", "bam");
        public readonly static ERPLanguage Belarusian = new ERPLanguage("Belarusian", "be", "bel");
        public readonly static ERPLanguage Bengali = new ERPLanguage("Bengali", "bn", "ben");
        public readonly static ERPLanguage Bislama = new ERPLanguage("Bislama", "bi", "bis");
        public readonly static ERPLanguage Tibetan = new ERPLanguage("Tibetan", "bo", "bod");
        public readonly static ERPLanguage Bosnian = new ERPLanguage("Bosnian", "bs", "bos");
        public readonly static ERPLanguage Breton = new ERPLanguage("Breton", "br", "bre");
        public readonly static ERPLanguage Bulgarian = new ERPLanguage("Bulgarian", "bg", "bul");
        public readonly static ERPLanguage Catalan = new ERPLanguage("Catalan", "ca", "cat");
        public readonly static ERPLanguage Czech = new ERPLanguage("Czech", "cs", "ces");
        public readonly static ERPLanguage Chamorro = new ERPLanguage("Chamorro", "ch", "cha");
        public readonly static ERPLanguage Chechen = new ERPLanguage("Chechen", "ce", "che");
        public readonly static ERPLanguage Chuvash = new ERPLanguage("Chuvash", "cv", "chv");
        public readonly static ERPLanguage Cornish = new ERPLanguage("Cornish", "kw", "cor");
        public readonly static ERPLanguage Corsican = new ERPLanguage("Corsican", "co", "cos");
        public readonly static ERPLanguage Cree = new ERPLanguage("Cree", "cr", "cre");
        public readonly static ERPLanguage Welsh = new ERPLanguage("Welsh", "cy", "cym");
        public readonly static ERPLanguage Danish = new ERPLanguage("Danish", "da", "dan");
        public readonly static ERPLanguage Dhivehi = new ERPLanguage("Dhivehi", "dv", "div");
        public readonly static ERPLanguage Dzongkha = new ERPLanguage("Dzongkha", "dz", "dzo");
        public readonly static ERPLanguage Greek = new ERPLanguage("Greek", "el", "ell");
        public readonly static ERPLanguage Estonian = new ERPLanguage("Estonian", "et", "est");
        public readonly static ERPLanguage Basque = new ERPLanguage("Basque", "eu", "eus");
        public readonly static ERPLanguage Ewe = new ERPLanguage("Ewe", "ee", "ewe");
        public readonly static ERPLanguage Faroese = new ERPLanguage("Faroese", "fo", "fao");
        public readonly static ERPLanguage Persian = new ERPLanguage("Persian", "fa", "fas");
        public readonly static ERPLanguage Fijian = new ERPLanguage("Fijian", "fj", "fij");
        public readonly static ERPLanguage Finnish = new ERPLanguage("Finnish", "fi", "fin");
        public readonly static ERPLanguage French = new ERPLanguage("French", "fr", "fra");
        public readonly static ERPLanguage WesternFrisian = new ERPLanguage("Western Frisian", "fy", "fry");
        public readonly static ERPLanguage Fulah = new ERPLanguage("Fulah", "ff", "ful");
        public readonly static ERPLanguage ScottishGaelic = new ERPLanguage("Scottish Gaelic", "gd", "gla");
        public readonly static ERPLanguage Irish = new ERPLanguage("Irish", "ga", "gle");
        public readonly static ERPLanguage Galician = new ERPLanguage("Galician", "gl", "glg");
        public readonly static ERPLanguage Manx = new ERPLanguage("Manx", "gv", "glv");
        public readonly static ERPLanguage Guarani = new ERPLanguage("Guarani", "gn", "grn");
        public readonly static ERPLanguage Gujarati = new ERPLanguage("Gujarati", "gu", "guj");
        public readonly static ERPLanguage Haitian = new ERPLanguage("Haitian", "ht", "hat");
        public readonly static ERPLanguage Hausa = new ERPLanguage("Hausa", "ha", "hau");
        public readonly static ERPLanguage SerboCroatian = new ERPLanguage("Serbo-Croatian", "sh", "");
        public readonly static ERPLanguage Hebrew = new ERPLanguage("Hebrew", "he", "heb");
        public readonly static ERPLanguage Herero = new ERPLanguage("Herero", "hz", "her");
        public readonly static ERPLanguage Hindi = new ERPLanguage("Hindi", "hi", "hin");
        public readonly static ERPLanguage HiriMotu = new ERPLanguage("Hiri Motu", "ho", "hmo");
        public readonly static ERPLanguage Croatian = new ERPLanguage("Croatian", "hr", "hrv");
        public readonly static ERPLanguage Hungarian = new ERPLanguage("Hungarian", "hu", "hun");
        public readonly static ERPLanguage Armenian = new ERPLanguage("Armenian", "hy", "hye");
        public readonly static ERPLanguage Igbo = new ERPLanguage("Igbo", "ig", "ibo");
        public readonly static ERPLanguage SichuanYi = new ERPLanguage("Sichuan Yi", "ii", "iii");
        public readonly static ERPLanguage Inuktitut = new ERPLanguage("Inuktitut", "iu", "iku");
        public readonly static ERPLanguage Indonesian = new ERPLanguage("Indonesian", "id", "ind");
        public readonly static ERPLanguage Inupiaq = new ERPLanguage("Inupiaq", "ik", "ipk");
        public readonly static ERPLanguage Icelandic = new ERPLanguage("Icelandic", "is", "isl");
        public readonly static ERPLanguage Italian = new ERPLanguage("Italian", "it", "ita");
        public readonly static ERPLanguage Javanese = new ERPLanguage("Javanese", "jv", "jav");
        public readonly static ERPLanguage Japanese = new ERPLanguage("Japanese", "ja", "jpn");
        public readonly static ERPLanguage Kalaallisut = new ERPLanguage("Kalaallisut", "kl", "kal");
        public readonly static ERPLanguage Kannada = new ERPLanguage("Kannada", "kn", "kan");
        public readonly static ERPLanguage Kashmiri = new ERPLanguage("Kashmiri", "ks", "kas");
        public readonly static ERPLanguage Georgian = new ERPLanguage("Georgian", "ka", "kat");
        public readonly static ERPLanguage Kanuri = new ERPLanguage("Kanuri", "kr", "kau");
        public readonly static ERPLanguage Kazakh = new ERPLanguage("Kazakh", "kk", "kaz");
        public readonly static ERPLanguage Khmer = new ERPLanguage("Khmer", "km", "khm");
        public readonly static ERPLanguage Kikuyu = new ERPLanguage("Kikuyu", "ki", "kik");
        public readonly static ERPLanguage Kinyarwanda = new ERPLanguage("Kinyarwanda", "rw", "kin");
        public readonly static ERPLanguage Kirghiz = new ERPLanguage("Kirghiz", "ky", "kir");
        public readonly static ERPLanguage Komi = new ERPLanguage("Komi", "kv", "kom");
        public readonly static ERPLanguage Kongo = new ERPLanguage("Kongo", "kg", "kon");
        public readonly static ERPLanguage Korean = new ERPLanguage("Korean", "ko", "kor");
        public readonly static ERPLanguage Kuanyama = new ERPLanguage("Kuanyama", "kj", "kua");
        public readonly static ERPLanguage Kurdish = new ERPLanguage("Kurdish", "ku", "kur");
        public readonly static ERPLanguage Lao = new ERPLanguage("Lao", "lo", "lao");
        public readonly static ERPLanguage Latvian = new ERPLanguage("Latvian", "lv", "lav");
        public readonly static ERPLanguage Limburgan = new ERPLanguage("Limburgan", "li", "lim");
        public readonly static ERPLanguage Lingala = new ERPLanguage("Lingala", "ln", "lin");
        public readonly static ERPLanguage Lithuanian = new ERPLanguage("Lithuanian", "lt", "lit");
        public readonly static ERPLanguage Luxembourgish = new ERPLanguage("Luxembourgish", "lb", "ltz");
        public readonly static ERPLanguage LubaKatanga = new ERPLanguage("Luba-Katanga", "lu", "lub");
        public readonly static ERPLanguage Ganda = new ERPLanguage("Ganda", "lg", "lug");
        public readonly static ERPLanguage Marshallese = new ERPLanguage("Marshallese", "mh", "mah");
        public readonly static ERPLanguage Malayalam = new ERPLanguage("Malayalam", "ml", "mal");
        public readonly static ERPLanguage Marathi = new ERPLanguage("Marathi", "mr", "mar");
        public readonly static ERPLanguage Macedonian = new ERPLanguage("Macedonian", "mk", "mkd");
        public readonly static ERPLanguage Malagasy = new ERPLanguage("Malagasy", "mg", "mlg");
        public readonly static ERPLanguage Maltese = new ERPLanguage("Maltese", "mt", "mlt");
        public readonly static ERPLanguage Mongolian = new ERPLanguage("Mongolian", "mn", "mon");
        public readonly static ERPLanguage Maori = new ERPLanguage("Maori", "mi", "mri");
        public readonly static ERPLanguage Malay = new ERPLanguage("Malay", "ms", "msa");
        public readonly static ERPLanguage Burmese = new ERPLanguage("Burmese", "my", "mya");
        public readonly static ERPLanguage Nauru = new ERPLanguage("Nauru", "na", "nau");
        public readonly static ERPLanguage Navajo = new ERPLanguage("Navajo", "nv", "nav");
        public readonly static ERPLanguage SouthNdebele = new ERPLanguage("South Ndebele", "nr", "nbl");
        public readonly static ERPLanguage NorthNdebele = new ERPLanguage("North Ndebele", "nd", "nde");
        public readonly static ERPLanguage Ndonga = new ERPLanguage("Ndonga", "ng", "ndo");
        public readonly static ERPLanguage Nepali = new ERPLanguage("Nepali", "ne", "nep");
        public readonly static ERPLanguage Dutch = new ERPLanguage("Dutch", "nl", "nld");
        public readonly static ERPLanguage NorwegianNynorsk = new ERPLanguage("Norwegian Nynorsk", "nn", "nno");
        public readonly static ERPLanguage NorwegianBokmal = new ERPLanguage("Norwegian Bokmål", "nb", "nob");
        public readonly static ERPLanguage Norwegian = new ERPLanguage("Norwegian", "no", "nor");
        public readonly static ERPLanguage Nyanja = new ERPLanguage("Nyanja", "ny", "nya");
        public readonly static ERPLanguage Occitan = new ERPLanguage("Occitan", "oc", "oci");
        public readonly static ERPLanguage Ojibwa = new ERPLanguage("Ojibwa", "oj", "oji");
        public readonly static ERPLanguage Oriya = new ERPLanguage("Oriya (macrolanguage)", "or", "ori");
        public readonly static ERPLanguage Oromo = new ERPLanguage("Oromo", "om", "orm");
        public readonly static ERPLanguage Ossetian = new ERPLanguage("Ossetian", "os", "oss");
        public readonly static ERPLanguage Panjabi = new ERPLanguage("Panjabi", "pa", "pan");
        public readonly static ERPLanguage Polish = new ERPLanguage("Polish", "pl", "pol");
        public readonly static ERPLanguage Portuguese = new ERPLanguage("Portuguese", "pt", "por");
        public readonly static ERPLanguage Pushto = new ERPLanguage("Pushto", "ps", "pus");
        public readonly static ERPLanguage Quechua = new ERPLanguage("Quechua", "qu", "que");
        public readonly static ERPLanguage Romansh = new ERPLanguage("Romansh", "rm", "roh");
        public readonly static ERPLanguage Romanian = new ERPLanguage("Romanian", "ro", "ron");
        public readonly static ERPLanguage Rundi = new ERPLanguage("Rundi", "rn", "run");
        public readonly static ERPLanguage Russian = new ERPLanguage("Russian", "ru", "rus");
        public readonly static ERPLanguage Sango = new ERPLanguage("Sango", "sg", "sag");
        public readonly static ERPLanguage Sinhala = new ERPLanguage("Sinhala", "si", "sin");
        public readonly static ERPLanguage Slovak = new ERPLanguage("Slovak", "sk", "slk");
        public readonly static ERPLanguage Slovenian = new ERPLanguage("Slovenian", "sl", "slv");
        public readonly static ERPLanguage NorthernSami = new ERPLanguage("Northern Sami", "se", "sme");
        public readonly static ERPLanguage Samoan = new ERPLanguage("Samoan", "sm", "smo");
        public readonly static ERPLanguage Shona = new ERPLanguage("Shona", "sn", "sna");
        public readonly static ERPLanguage Sindhi = new ERPLanguage("Sindhi", "sd", "snd");
        public readonly static ERPLanguage Somali = new ERPLanguage("Somali", "so", "som");
        public readonly static ERPLanguage SouthernSotho = new ERPLanguage("Southern Sotho", "st", "sot");
        public readonly static ERPLanguage Spanish = new ERPLanguage("Spanish", "es", "spa");
        public readonly static ERPLanguage Albanian = new ERPLanguage("Albanian", "sq", "sqi");
        public readonly static ERPLanguage Sardinian = new ERPLanguage("Sardinian", "sc", "srd");
        public readonly static ERPLanguage Serbian = new ERPLanguage("Serbian", "sr", "srp");
        public readonly static ERPLanguage Swati = new ERPLanguage("Swati", "ss", "ssw");
        public readonly static ERPLanguage Sundanese = new ERPLanguage("Sundanese", "su", "sun");
        public readonly static ERPLanguage Swahili = new ERPLanguage("Swahili (macrolanguage)", "sw", "swa");
        public readonly static ERPLanguage Swedish = new ERPLanguage("Swedish", "sv", "swe");
        public readonly static ERPLanguage Tahitian = new ERPLanguage("Tahitian", "ty", "tah");
        public readonly static ERPLanguage Tamil = new ERPLanguage("Tamil", "ta", "tam");
        public readonly static ERPLanguage Tatar = new ERPLanguage("Tatar", "tt", "tat");
        public readonly static ERPLanguage Telugu = new ERPLanguage("Telugu", "te", "tel");
        public readonly static ERPLanguage Tajik = new ERPLanguage("Tajik", "tg", "tgk");
        public readonly static ERPLanguage Tagalog = new ERPLanguage("Tagalog", "tl", "tgl");
        public readonly static ERPLanguage Thai = new ERPLanguage("Thai", "th", "tha");
        public readonly static ERPLanguage Tigrinya = new ERPLanguage("Tigrinya", "ti", "tir");
        public readonly static ERPLanguage Tonga = new ERPLanguage("Tonga (Tonga Islands)", "to", "ton");
        public readonly static ERPLanguage Tswana = new ERPLanguage("Tswana", "tn", "tsn");
        public readonly static ERPLanguage Tsonga = new ERPLanguage("Tsonga", "ts", "tso");
        public readonly static ERPLanguage Turkmen = new ERPLanguage("Turkmen", "tk", "tuk");
        public readonly static ERPLanguage Turkish = new ERPLanguage("Turkish", "tr", "tur");
        public readonly static ERPLanguage Twi = new ERPLanguage("Twi", "tw", "twi");
        public readonly static ERPLanguage Uighur = new ERPLanguage("Uighur", "ug", "uig");
        public readonly static ERPLanguage Ukrainian = new ERPLanguage("Ukrainian", "uk", "ukr");
        public readonly static ERPLanguage Urdu = new ERPLanguage("Urdu", "ur", "urd");
        public readonly static ERPLanguage Uzbek = new ERPLanguage("Uzbek", "uz", "uzb");
        public readonly static ERPLanguage Venda = new ERPLanguage("Venda", "ve", "ven");
        public readonly static ERPLanguage Vietnamese = new ERPLanguage("Vietnamese", "vi", "vie");
        public readonly static ERPLanguage Walloon = new ERPLanguage("Walloon", "wa", "wln");
        public readonly static ERPLanguage Wolof = new ERPLanguage("Wolof", "wo", "wol");
        public readonly static ERPLanguage Xhosa = new ERPLanguage("Xhosa", "xh", "xho");
        public readonly static ERPLanguage Yiddish = new ERPLanguage("Yiddish", "yi", "yid");
        public readonly static ERPLanguage Yoruba = new ERPLanguage("Yoruba", "yo", "yor");
        public readonly static ERPLanguage Zhuang = new ERPLanguage("Zhuang", "za", "zha");
        public readonly static ERPLanguage Chinese = new ERPLanguage("Chinese", "zh", "zho");
        public readonly static ERPLanguage Zulu = new ERPLanguage("Zulu", "zu", "zul");
    }
}

//Datasource: https://iso639-3.sil.org/sites/iso639-3/files/downloads/iso-639-3.tab
