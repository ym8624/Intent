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
    [Activity(Label = "SetOperationActivity")]
    public class SetOperationActivity : Activity
    {
        private TextView tvOp;
        private Button btnReturn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            InitializeViews();
        }

        private void InitializeViews()
        {
            tvOp = FindViewById<TextView>(Resource.Id.tvOp);
            btnReturn = FindViewById<Button>(Resource.Id.btnReturn);

            btnReturn.Click += btnReturn_click;
        }

        private void btnReturn_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}