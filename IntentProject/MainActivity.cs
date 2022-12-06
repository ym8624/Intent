using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace IntentProject
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText etNum1;
        private EditText etOp;
        private EditText etNum2;
        private TextView tvEqual;
        private EditText etRes;
        private Button btnSetNum;
        private Button btnSetOp;
        private Button btnGetRes;
        private Button btnCheck;
        private int num1;
        private int num2;
        private char Op;
        private int result;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            InitializeViews();
        }

        private void InitializeViews()
        {
            etNum1 = FindViewById<EditText>(Resource.Id.etNum1);
            etOp = FindViewById<EditText>(Resource.Id.etOp);
            etNum2 = FindViewById<EditText>(Resource.Id.etNum2);
            tvEqual = FindViewById<TextView>(Resource.Id.tvEqual);
            etRes = FindViewById<EditText>(Resource.Id.etRes);
            btnSetNum = FindViewById<Button>(Resource.Id.btnSetNum);
            btnSetOp = FindViewById<Button>(Resource.Id.btnSetOp);
            btnGetRes = FindViewById<Button>(Resource.Id.btnGetRes);
            btnCheck = FindViewById<Button>(Resource.Id.btnCheck);

            btnSetNum.Click += btnSetNum_click;
            btnSetOp.Click += btnSetOp_click;
            btnGetRes.Click += btnGetRes_click;
            btnCheck.Click += btnCheck_click;

        }

        private void btnCheck_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGetRes_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSetOp_click(object sender, EventArgs e)
        {
            Intent intentOp = new Intent(this, typeof(SetOperationActivity));
            intentOp.PutExtra("OP", etOp.Text);
        }

        private void btnSetNum_click(object sender, EventArgs e)
        {
            Intent intentNumbers = new Intent(this, typeof(SetNumbersActivity));
            intentNumbers.PutExtra("LOW", 0);
            intentNumbers.PutExtra("HIGH", 100);
            StartActivityForResult(intentNumbers, 1);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}