using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntentProject
{
    [Activity(Label = "SetNumbersActivity")]
    public class SetNumbersActivity : Activity
    {
        private TextView tvNum1;
        private TextView tvNum2;
        private Button btnReturn;
        private int low;
        private int high;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            InitializeViews();
            low = Intent.GetIntExtra("LOW",0);
            high = Intent.GetIntExtra("HIGH", 100);

            Random rnd = new Random();

            tvNum1.Text = rnd.Next(low, high + 1).ToString();
            tvNum2.Text = rnd.Next(low, high + 1).ToString();
        }

        private void InitializeViews()
        {
            tvNum1 = FindViewById<TextView>(Resource.Id.tvNum1);
            tvNum2 = FindViewById<TextView>(Resource.Id.tvNum2);
            btnReturn = FindViewById<Button>(Resource.Id.btnReturn);

            btnReturn.Click += btnReturn_click;
        }

        private void btnReturn_click(object sender, EventArgs e)
        {
            Intent intent = new Intent();
            intent.PutExtra("NUM1", tvNum1.Text);
            intent.PutExtra("NUM2", tvNum2.Text);
            SetResult(Result.Ok, intent);
            Finish();
        }

    }
}