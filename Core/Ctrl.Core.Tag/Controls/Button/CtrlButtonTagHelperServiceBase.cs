﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Ctrl.Core.Tag.Controls.Button
{
    public abstract class CtrlButtonTagHelperServiceBase<TTagHelper> : CtrlButtonTagHelperService<TTagHelper> where TTagHelper : TagHelper, IButtonTagHelperBase
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (TagHelper.ButtonType!= CtrlButtonType.Default)
            {
                output.TagName = "button";
                output.TagMode = TagMode.StartTagAndEndTag;
                output.Attributes.SetAttribute("class", "btn btn-" + CtrlButtonType.Primary.ToString().ToLowerInvariant());
                output.Attributes.SetAttribute("btn-", CtrlButtonType.Default.ToString());
            }
           
           
            //if (TagHelper.ButtonType != AbpButtonType.Default)
            //{
            //    output.Attributes.AddClass("btn-" + TagHelper.ButtonType.ToString().ToLowerInvariant().Replace("_", "-"));
            //}

            //if (TagHelper.Size != AbpButtonSize.Default)
            //{
            //    output.Attributes.AddClass(TagHelper.Size.ToClassName());
            //}
        }
    }
}
