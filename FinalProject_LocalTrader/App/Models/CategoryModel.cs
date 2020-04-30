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
        // todo: polaczenie wiele do wiele miedzy kategoriami i produktami
        // tak jak tagi w bookmarksgoogle
    }
}
