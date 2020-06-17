using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Converter
{
    public static class NumberConverter
    {
        public static string PersianToEnglish(this string persianStr)
        {
            if (persianStr != null)
            {
                Dictionary<char, char> LettersDictionary = new Dictionary<char, char>
                {
                    ['۰'] = '0',
                    ['۱'] = '1',
                    ['۲'] = '2',
                    ['۳'] = '3',
                    ['۴'] = '4',
                    ['۵'] = '5',
                    ['۶'] = '6',
                    ['٧'] = '7',
                    ['۸'] = '8',
                    ['۹'] = '9'
                };
                foreach (var item in persianStr)
                {
                    try
                    {
                        persianStr = persianStr.Replace(item, LettersDictionary[item]);
                    }
                    catch
                    {

                    }

                }
            }

            return persianStr;
        }

        public static string EnglishToPersian(this string EnglishStr)
        {
            if (EnglishStr != null)
            {
                Dictionary<char, char> LettersDictionary = new Dictionary<char, char>
                {
                    ['0'] = '۰',
                    ['1'] = '۱',
                    ['2'] = '۲',
                    ['3'] = '۳',
                    ['4'] = '۴',
                    ['5'] = '۵',
                    ['6'] = '۶',
                    ['7'] = '۷',
                    ['8'] = '۸',
                    ['9'] = '۹',
                    ['۰'] = '۰',
                    ['۱'] = '۱',
                    ['۲'] = '۲',
                    ['۳'] = '۳',
                    ['۴'] = '۴',
                    ['۵'] = '۵',
                    ['۶'] = '۶',
                    ['۷'] = '۷',
                    ['۸'] = '۸',
                    ['۹'] = '۹',
                    ['/'] = '/'
                };
                foreach (var item in EnglishStr)
                {
                    EnglishStr = EnglishStr.Replace(item, LettersDictionary[item]);
                }
            }

            return EnglishStr;
        }
    }
}
