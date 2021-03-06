﻿using Cirrious.FluentLayouts.Touch;
using FlexiMvvm.Views;
using Sample.iOS.Themes;
using UIKit;

namespace Sample.iOS.Views
{
    public class UserProfileView : LayoutView
    {
        public UITextField FirstName { get; set; }

        public UITextField LastName { get; set; }

        public UITextField Email { get; set; }

        public UILabel LanguageSelected { get; set; }

        public UIButton SaveButton { get; private set; }

        public UIButton SelectLanguageButton { get; private set; }

        private UILabel FirstNameLabel { get; set; }

        private UILabel LastNameLabel { get; set; }

        private UILabel EmailLabel { get; set; }

        private UILabel LanguageLabel { get; set; }

        protected override void SetupSubviews()
        {
            base.SetupSubviews();

            BackgroundColor = Theme.Colors.BackgroundColor;

            FirstNameLabel = new UILabel().AsRegularBodyStyle("First Name:");
            LastNameLabel = new UILabel().AsRegularBodyStyle("Last Name:");
            EmailLabel = new UILabel().AsRegularBodyStyle("Email:");
            LanguageLabel = new UILabel().AsRegularBodyStyle("Language:");

            FirstName = new UITextField().AsTextFieldStyle("...");
            LastName = new UITextField().AsTextFieldStyle("...");
            Email = new UITextField().AsTextFieldStyle("example@icloud.com");
            LanguageSelected = new UILabel().AsEmphasizedBodyStyle(string.Empty);

            SelectLanguageButton = new UIButton().AsRegularButtonStyle("Change");
            SaveButton = new UIButton().AsRegularButtonStyle("Save");
        }

        protected override void SetupLayout()
        {
            base.SetupLayout();

            AddSubview(FirstNameLabel);
            AddSubview(LastNameLabel);
            AddSubview(EmailLabel);
            AddSubview(FirstName);
            AddSubview(LastName);
            AddSubview(Email);
            AddSubview(LanguageLabel);
            AddSubview(LanguageSelected);
            AddSubview(SelectLanguageButton);
            AddSubview(SaveButton);
        }

        protected override void SetupLayoutConstraints()
        {
            base.SetupLayoutConstraints();
            this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            this.AddConstraints(
                FirstNameLabel.AtLeftOf(this, Theme.Dimensions.Inset2x),
                FirstNameLabel.AtTopOfSafeArea(this, Theme.Dimensions.Inset2x),
                FirstNameLabel.AtRightOf(this, Theme.Dimensions.Inset2x),
                FirstNameLabel.Height().EqualTo(Theme.Dimensions.LabelBodyHeight));
            this.AddConstraints(
                FirstName.AtLeftOf(this, Theme.Dimensions.Inset3x),
                FirstName.Below(FirstNameLabel, Theme.Dimensions.Inset1x),
                FirstName.AtRightOf(this, Theme.Dimensions.Inset2x),
                FirstName.Height().EqualTo(Theme.Dimensions.TextFieldRegularHeight));

            this.AddConstraints(
                LastNameLabel.AtLeftOf(this, Theme.Dimensions.Inset2x),
                LastNameLabel.Below(FirstName, Theme.Dimensions.Inset1x),
                LastNameLabel.AtRightOf(this, Theme.Dimensions.Inset2x),
                LastNameLabel.Height().EqualTo(Theme.Dimensions.LabelBodyHeight));
            this.AddConstraints(
                LastName.AtLeftOf(this, Theme.Dimensions.Inset3x),
                LastName.Below(LastNameLabel, Theme.Dimensions.Inset1x),
                LastName.AtRightOf(this, Theme.Dimensions.Inset2x),
                LastName.Height().EqualTo(Theme.Dimensions.TextFieldRegularHeight));

            this.AddConstraints(
                EmailLabel.AtLeftOf(this, Theme.Dimensions.Inset2x),
                EmailLabel.Below(LastName, Theme.Dimensions.Inset1x),
                EmailLabel.AtRightOf(this, Theme.Dimensions.Inset2x),
                EmailLabel.Height().EqualTo(Theme.Dimensions.LabelBodyHeight));
            this.AddConstraints(
                Email.AtLeftOf(this, Theme.Dimensions.Inset3x),
                Email.Below(EmailLabel, Theme.Dimensions.Inset1x),
                Email.AtRightOf(this, Theme.Dimensions.Inset2x),
                Email.Height().EqualTo(Theme.Dimensions.TextFieldRegularHeight));

            this.AddConstraints(
                LanguageLabel.AtLeftOf(this, Theme.Dimensions.Inset2x),
                LanguageLabel.Below(Email, Theme.Dimensions.Inset1x),
                LanguageLabel.AtRightOf(this, Theme.Dimensions.Inset2x),
                LanguageLabel.Height().EqualTo(Theme.Dimensions.LabelBodyHeight));
            this.AddConstraints(
                LanguageSelected.AtLeftOf(this, Theme.Dimensions.Inset3x),
                LanguageSelected.Below(LanguageLabel, Theme.Dimensions.Inset1x),
                LanguageSelected.Height().EqualTo(Theme.Dimensions.TextFieldRegularHeight));
            this.AddConstraints(
                SelectLanguageButton.Width().EqualTo(80),
                SelectLanguageButton.Below(LanguageLabel, Theme.Dimensions.Inset2x),
                SelectLanguageButton.AtRightOf(this, Theme.Dimensions.Inset2x),
                SelectLanguageButton.Height().EqualTo(Theme.Dimensions.ButtonRegularHeight));

            this.AddConstraints(
                SaveButton.Width().EqualTo(80),
                SaveButton.Below(SelectLanguageButton, Theme.Dimensions.Inset6x),
                SaveButton.AtRightOf(this, Theme.Dimensions.Inset2x),
                SaveButton.Height().EqualTo(Theme.Dimensions.ButtonRegularHeight));
        }
    }
}
