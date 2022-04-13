using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public enum EPeriod
    {
        Week = 7,
        Halfmonth = 15,
        Month = 30,
        Quarter = 90
    }
    public enum EResolution
    {
        Low = 1,
        Medium = 2,
        High = 3
    }
    public class Tariff : BaseModel
    {
        [Required(ErrorMessage = "Введите начисление по тарифу")]
        long Price;
        [Required(ErrorMessage = "Введите период хранения")]
        EPeriod Period;
        [Required(ErrorMessage = "Введите качество разрешения")]
        EResolution Resolution;
    }
}
