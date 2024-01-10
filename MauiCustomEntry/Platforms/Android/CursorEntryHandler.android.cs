using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;

namespace MauiCustomEntry.Components.CustomEntry
{
    public partial class CursorEntryHandler : EntryHandler
    {
        private AppCompatEditText? _nativeEntry;

        protected override AppCompatEditText CreatePlatformView()
        {
            _nativeEntry = new AppCompatEditText(Context);
            return _nativeEntry;
        }

        internal void SetCursorColor(CursorEntry entry)
        {
            _nativeEntry?.TextCursorDrawable?.SetTint(entry.CursorColor.ToAndroid());
        }
    }
}