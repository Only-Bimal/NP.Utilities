﻿using System;

namespace NP.Utilities.PluginUtils
{
    public class VisualPluginInfo<TKey> : ViewModelPluginInfo<TKey>
    {
        public string ViewDataTemplateResourcePath { get; set; }
        public object ViewDataTemplateResourceKey { get; set; }

        public VisualPluginInfo()
        {

        }

        public VisualPluginInfo
        (
            Type viewModelType, 
            TKey viewModelKey,
            string viewDataTemplateResourcePath,
            object viewDataTemplateResourceKey) 
            : 
            base(viewModelType, viewModelKey)
        {
            ViewDataTemplateResourcePath = viewDataTemplateResourcePath;
            ViewDataTemplateResourceKey = viewDataTemplateResourceKey;
        }
    }

    public class VisualPluginInfo : VisualPluginInfo<object?>
    {
        public VisualPluginInfo()
        {
            
        }

        public VisualPluginInfo(
            Type viewModelType,
            object? viewModelKey,
            string viewDataTemplateResourcePath,
            object viewDataTemplateResourceKey)
            :
            base(viewModelType, viewModelKey, viewDataTemplateResourcePath, viewDataTemplateResourceKey)
        {
            
        }
    }
}
