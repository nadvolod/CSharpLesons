using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section15
{
    class ComplicatedPage : BasePage
    {
        public SectionOfButtons ButtonsSection { get; set; }
        public SectionOfSocialMedia SocialMediaSection{get;set;}
        public SectionOfRandomStuff RandomStuffSection { get; set; }
        public override string PageName { get => "Complicated Page"; }
    }
}
