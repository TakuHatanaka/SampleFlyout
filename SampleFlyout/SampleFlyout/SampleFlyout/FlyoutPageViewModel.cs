using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFlyout
{
    public class FlyoutPageViewModel
    {
        public List<ItemModel> Items { get; set; }
    }

    public class ItemModel
    {
        public string Text
        {
            get;
            set;
        }
    }
}
