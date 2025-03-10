using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SanzaruProductions
{
    [System.Serializable]
    public class Value
    {
        public Card.CardEffect ce;
        public float value;
        public float duration;
    }


    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class Card : ScriptableObject
    {
        public string cardName;
        public List<CardType> CardCombination;
        public DamageType damageType;
        public List<Value> cardEffect;


        public enum CardEffect
        {
            Poison, // яд
            Stun, // стан
            Evasion, // уклонение
            Armor,// добавляет броню в %
            Penetration,//пробитие брони
            Disarm, //Нельзя атаковать
            Shield, // добавляет щит флатовый
            Regen, //восстанавливает здоровье опредю кол-во ходов
            Heal, //мнгновенное вост. здоровья
            Damage //УРОН.

        }

        public enum CardType
        {
            Attack,
            Defence,
            Action
        }

        public enum DamageType
        {
            Pure,
            Magic,
        }

    }
}