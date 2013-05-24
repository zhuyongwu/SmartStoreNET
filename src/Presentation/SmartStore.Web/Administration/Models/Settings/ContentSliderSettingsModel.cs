﻿using SmartStore.Web.Framework;
using SmartStore.Web.Framework.Mvc;
using SmartStore.Web.Framework.Localization;
using System;
﻿using System.Collections.Generic;
using SmartStore.Core.Configuration;
﻿using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using FluentValidation.Attributes;
using SmartStore.Admin.Validators.ContentSlider;

namespace SmartStore.Admin.Models.ContentSlider
{
    //[Validator(typeof(ContentSliderValidator))]
    public class ContentSliderSettingsModel : EntityModelBase
    {
        public ContentSliderSettingsModel()
        {
            Slides = new List<ContentSliderSlideModel>();
        }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.IsActive")]
        public bool IsActive { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.SliderHeight")]
        public string ContentSliderHeight { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Background")]
        public int BackgroundPictureId { get; set; }

        public string BackgroundPictureUrl { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.AutoPlay")]
        public bool AutoPlay { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.AutoPlayDelay")]
        public int AutoPlayDelay { get; set; }

        public IList<ContentSliderSlideModel> Slides { get; set; }

    }

    [Validator(typeof(ContentSliderSlideValidator))]
    public class ContentSliderSlideModel : EntityModelBase
    {
        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Title")]
        [AllowHtml]
        public string Title { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Text")]
        [AllowHtml]
        public string Text { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Picture")]
        public int PictureId { get; set; }

        public string PictureUrl { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Language")]
        public string LanguageName { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Language")]
        public string LanguageCulture { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Published")]
        public bool Published { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Button1")]
        public ContentSliderButtonModel Button1 { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Button2")]
        public ContentSliderButtonModel Button2 { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Slide.Button3")]
        public ContentSliderButtonModel Button3 { get; set; }

    }

    [Validator(typeof(ContentSliderButtonValidator))]
    public class ContentSliderButtonModel : EntityModelBase
    {
        [Display(Description = "Admin.Configuration.ContentSlider.Button.Text.Hint")]
        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Button.Text")]
        public string Text { get; set; }

        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Button.Type")]
        [Display(Description = "Admin.Configuration.ContentSlider.Button.Type.Hint")]
        [UIHint("ButtonType")]
        public string Type { get; set; }

        [Display(Description = "Admin.Configuration.ContentSlider.Button.Url.Hint")]
        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Button.Url")]
        public string Url { get; set; }

        [Display(Description = "Admin.Configuration.ContentSlider.Button.Published.Hint")]
        [SmartResourceDisplayName("Admin.Configuration.ContentSlider.Button.Published")]
        public bool Published { get; set; }
    }
}