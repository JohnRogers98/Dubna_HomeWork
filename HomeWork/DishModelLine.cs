namespace HomeWork
{
    /*
    15. 
    Определить класс «Посуда», содержащий следующие поля:
        • номер посуды
        • стоимость 1 тарелки
        • стоимость 1 чашки
        • стоимость 1 блюдца
    Определить методы класса:
        • стоимость набора посуды: 3 чашки + 3 блюдца
        • стоимость набора посуды: 3 чашки + 3 блюдца + 3 тарелки
        • стоимость набора посуды: 6 чашек + 6 блюдец + 6 тарелок
     */

    //TODO: can be made polymorphic
    internal class DishModelLine
    {
        public Guid Id { get; set; }
        
        public Double Plate { get; set; }
        public Double Cup { get; set; }
        public Double Saucer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="goods">Names of goods and their corresponding count</param>
        /// <returns></returns>
        public Double EstimatePrice(IDictionary<String, Int32> goods)
        {
            Double totalPrice = 0;

            foreach(var good in goods)
            {
                if (good.Value <= 0)
                    continue;

                switch (good.Key)
                {
                    case nameof(Plate): totalPrice += Plate * good.Value; break;
                    case nameof(Cup): totalPrice += Cup * good.Value; break;
                    case nameof(Saucer): totalPrice += Saucer * good.Value; break;
                    default: break;
                }
            }
            return totalPrice;
        }

        /// <summary>
        /// Стоимость набора посуды: 3 чашки + 3 блюдца
        /// </summary>
        public Double Estimate3CupsAndSaucers()
        {
            var goods = new Dictionary<String, Int32>
            {
                { nameof(Cup), 3},
                { nameof(Saucer), 3},
            };

            return this.EstimatePrice(goods);
        }

        /// <summary>
        /// Стоимость набора посуды: 3 чашки + 3 блюдца + 3 тарелки
        /// </summary>
        public Double Estimate3CupsAndSaucersAndPlates()
        {
            var goods = new Dictionary<String, Int32>
            {
                { nameof(Cup), 3},
                { nameof(Saucer), 3},
                { nameof(Plate), 3},
            };

            return this.EstimatePrice(goods);
        }

        /// <summary>
        /// Стоимость набора посуды: 6 чашки + 6 блюдца + 6 тарелки
        /// </summary>
        public Double Estimate6CupsAndSaucersAndPlates()
        {
            var goods = new Dictionary<String, Int32>
            {
                { nameof(Cup), 6},
                { nameof(Saucer), 6},
                { nameof(Plate), 6},
            };

            return this.EstimatePrice(goods);
        }

    }

}
