﻿namespace KRFHomepage.Domain.Database.Common
{
    using System.Collections.Generic;

    using KRFHomepage.Domain.Database.Homepage;
    using KRFHomepage.Domain.Database.Translations;
    public class Language
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual HomePageData HomePageData { get; set; }
        public virtual ICollection<Translation> Translations { get; set; }
        public virtual ICollection<ErrorTranslation> ErrorTranslations { get; set; }
    }
}
