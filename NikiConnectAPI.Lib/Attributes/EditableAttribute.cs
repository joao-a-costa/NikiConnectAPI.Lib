using System;

namespace NikiConnectAPI.Lib.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EditableAttribute : Attribute
    {
        public bool IsEditable { get; } = false;

        public EditableAttribute(bool isEditable)
        {
            IsEditable = isEditable;
        }
    }
}
