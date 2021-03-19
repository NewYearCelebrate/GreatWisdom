using System;
using System.Collections.Generic;
using System.Text;
using GreatWisdom;

namespace GreatWisdom.DataBase
{
    public class JsonTools
    {
        //Serializer for simple 1 level depth types
        public static string Serialize<T>(string toSerialize, T defeatedMonster) where T : new()
        {
            string prefix = "{ \"WisdomsList\":[";
            //foreach (string wisdom in defeatedMonster.WisdomsList)
            //    prefix += ( "\"" + wisdom + "\",");

            string postfix = "}";

            string serializingString = prefix + toSerialize + postfix;


            //Check if DeserializeMonsterData works properly
            if (Deserialize<T>(serializingString) != null)
            {
                
            }
            else
            {
                //Get data from Monster Data
            }

            //while writing serializingString for MonsterData
            //if there is already serialized data for certain monster 
            //=> deserialize it, summ with serializingString and serialize
            
            return null;
        }

        public static T Deserialize<T>(string toDeserialize) where T : new()
        {
            T t = new T();
            return t;
        }
    }


    public class MonsterData
    {
        public List<string> WisdomsList = new List<string>();
        public List<string> WinningHeroesNames = new List<string>();
        public string monsterName = "";
    }
    //winning sequence будет храниться отдельно


    public class HeroData
    {

    }
}
