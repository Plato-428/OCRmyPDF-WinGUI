using System.Collections.ObjectModel;

namespace OcrMyPdf.Logic.Options
{
    public static class CleaningOption
    {
        public static readonly ObservableCollection<MultiOptionTemplate> OptionList = new ObservableCollection<MultiOptionTemplate>
        {
            new MultiOptionTemplate(
                "Disabled",
                "",
                "Disabled",
                ""),

            new MultiOptionTemplate(
                "Clean",
                "--clean",
                "Clean",
                "Clean pages before OCR"),

            new MultiOptionTemplate(
                "CleanFinal",
                "--clean-final",
                "Clean Final",
                "Clean pages and keep cleaned images in output")
        };
    }
}
