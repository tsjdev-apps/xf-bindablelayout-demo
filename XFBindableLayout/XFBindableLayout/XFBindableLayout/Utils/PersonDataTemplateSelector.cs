using Xamarin.Forms;
using XFBindableLayout.Models;

namespace XFBindableLayout.Utils
{
    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FemaleDataTemplate { get; set; }
        public DataTemplate MaleDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Person person)
            {
                switch (person.Gender)
                {
                    case Gender.Female:
                        return FemaleDataTemplate;
                    case Gender.Male:
                        return MaleDataTemplate;
                }
            }

            return null;
        }
    }
}
