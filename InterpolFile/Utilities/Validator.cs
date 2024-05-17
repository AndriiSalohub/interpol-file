using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterpolFile.Utilities
{
    public static class Validator
    {
        public static void AttachValidatingHandlers(Dictionary<TextBoxBase, Label> fieldsToValidate)
        {
            foreach (var pair in fieldsToValidate)
            {
                pair.Key.Validating += (sender, e) => ValidateTextField(pair.Key, pair.Value);
                pair.Key.Validated += (sender, e) => HideErrorLabel(pair.Value);
            }
        }

        public static bool ValidateFields(Dictionary<TextBoxBase, Label> fieldsToValidate)
        {
            bool allFieldsValid = true;

            foreach (var kv in fieldsToValidate)
            {
                if (!ValidateTextField(kv.Key, kv.Value))
                {
                    allFieldsValid = false;
                }
            }

            return allFieldsValid;
        }

        private static bool ValidateTextField(TextBoxBase textBox, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text);
            errorLabel.Visible = !isValid;
            return isValid;
        }

        private static void HideErrorLabel(Label errorLabel)
        {
            errorLabel.Visible = false;
        }

        public static Dictionary<TextBoxBase, Label> GetValidationFields(
         TextBoxBase firstNameTextBox, Label firstNameErrorLabel,
         TextBoxBase lastNameTextBox, Label lastNameErrorLabel,
         TextBoxBase hairColorTextBox, Label hairColorErrorLabel,
         TextBoxBase eyesColorTextBox, Label eyesColorErrorLabel,
         TextBoxBase birthPlaceTextBox, Label birthPlaceErrorLabel,
         TextBoxBase aliasTextBox, Label aliasErrorLabel,
         TextBoxBase distinguishingFeaturesTextBox, Label distinguishingFeaturesErrorLabel,
         TextBoxBase professionTextBox, Label professionErrorLabel,
         TextBoxBase lastCrimeTextBox, Label lastCrimeErrorLabel,
         TextBoxBase languagesTextBox, Label languagesErrorLabel,
         TextBoxBase lastKnownPlaceTextBox, Label lastPlaceErrorLabel)
        {
            return new Dictionary<TextBoxBase, Label>
            {
                { firstNameTextBox, firstNameErrorLabel },
                { lastNameTextBox, lastNameErrorLabel },
                { hairColorTextBox, hairColorErrorLabel },
                { eyesColorTextBox, eyesColorErrorLabel },
                { birthPlaceTextBox, birthPlaceErrorLabel },
                { aliasTextBox, aliasErrorLabel },
                { distinguishingFeaturesTextBox, distinguishingFeaturesErrorLabel },
                { professionTextBox, professionErrorLabel },
                { lastCrimeTextBox, lastCrimeErrorLabel },
                { languagesTextBox, languagesErrorLabel },
                { lastKnownPlaceTextBox, lastPlaceErrorLabel }
            };
        }
    }
}