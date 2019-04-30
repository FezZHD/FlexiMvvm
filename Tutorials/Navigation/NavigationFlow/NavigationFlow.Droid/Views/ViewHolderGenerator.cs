﻿// <auto-generated />
// ReSharper disable All
using System;
using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace NavigationFlow.Droid.Views
{
    public partial class FirstActivityViewHolder
    {
         private readonly Activity activity;

         private Button nextButton;

        public FirstActivityViewHolder( Activity activity)
        {
            if (activity == null) throw new ArgumentNullException(nameof(activity));

            this.activity = activity;
        }

        
        public Button NextButton =>
            nextButton ?? (nextButton = activity.FindViewById<Button>(Resource.Id.next_button));
    }

    public partial class HomeActivityViewHolder
    {
         private readonly Activity activity;

         private TextView resultTextView;
         private Button nextButton;

        public HomeActivityViewHolder( Activity activity)
        {
            if (activity == null) throw new ArgumentNullException(nameof(activity));

            this.activity = activity;
        }

        
        public TextView ResultTextView =>
            resultTextView ?? (resultTextView = activity.FindViewById<TextView>(Resource.Id.result_text_view));

        
        public Button NextButton =>
            nextButton ?? (nextButton = activity.FindViewById<Button>(Resource.Id.next_button));
    }

    public partial class SecondActivityViewHolder
    {
         private readonly Activity activity;

         private Button nextButton;

        public SecondActivityViewHolder( Activity activity)
        {
            if (activity == null) throw new ArgumentNullException(nameof(activity));

            this.activity = activity;
        }

        
        public Button NextButton =>
            nextButton ?? (nextButton = activity.FindViewById<Button>(Resource.Id.next_button));
    }

    public partial class ThirdActivityViewHolder
    {
         private readonly Activity activity;

         private EditText resultEditText;
         private Button acceptButton;
         private Button declineButton;

        public ThirdActivityViewHolder( Activity activity)
        {
            if (activity == null) throw new ArgumentNullException(nameof(activity));

            this.activity = activity;
        }

        
        public EditText ResultEditText =>
            resultEditText ?? (resultEditText = activity.FindViewById<EditText>(Resource.Id.result_edit_text));

        
        public Button AcceptButton =>
            acceptButton ?? (acceptButton = activity.FindViewById<Button>(Resource.Id.accept_button));

        
        public Button DeclineButton =>
            declineButton ?? (declineButton = activity.FindViewById<Button>(Resource.Id.decline_button));
    }

}
// ReSharper restore All