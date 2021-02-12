using System;
using System.Collections.Generic;
using System.Text;

namespace ClassIntroductionPractice
{
    public class Money
    {
        int nominal;       
        int quantityNotes; 
        int totalCash = 0;

        public Money()
        {
            nominal = 0;
            quantityNotes = 0;
        }

        public Money(int nominal, int quantityNotes)
        {
            this.nominal = nominal;
            this.quantityNotes = quantityNotes;
        }

        public override string ToString()
        {
            return $"У Вас в кармане {quantityNotes} куп. номиналом {nominal} тнг.";
        }

        public string CheckAvailability(double costOfGoods)
        {
            totalCash = nominal * quantityNotes;   
            if (costOfGoods < totalCash)
            {
                return $"У Вас достаточно наличных ({totalCash} тнг.) для покупки товара стоимость {costOfGoods} тнг.";
            }
            else
            {
                return $"К сожалению, для покупки товара стоимостью {costOfGoods} Вам не хватает {costOfGoods - totalCash} тнг. ";
            }
        }

        public string CalculationOfQuantity(double costOfGoods)
        {
            int quantityGoods = (int)(totalCash / costOfGoods);
            return $"На имеющиеся {totalCash} тнг. можно купить {quantityGoods} ед. товара стоимостью {costOfGoods} грн.";
        }

        public int Nominal
        {
            get => nominal;
            set => nominal = value;
        }

        public int QuantityNotes
        {
            get => quantityNotes;
            set => quantityNotes = value;
        }

        public int TotalCash
        {
            get => totalCash;
        }
    }
}
