using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductModel> Products { get; set; }
        // todo: polaczenie jeden do wiele miedzy kategoriami i produktami
        // w przyszłości: tak jak tagi w bookmarksgoogle
    }
}
