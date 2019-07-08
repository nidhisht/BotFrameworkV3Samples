
# FormFlow Samples

#### Important Files:
1. MessageController.cs
2. BugReport.cs

#### What to look in /Controllers/MessagesController.cs?
        internal static IDialog<BugReport> MakeRootDialog()
        {
            return Chain.From(() => FormDialog.FromForm(BugReport.BuildForm));
        }

#### What to look in /Models/BugReport.cs?
        public static IForm<BugReport> BuildForm()
        {
            return new FormBuilder<BugReport>().
                Message("**Bug Details**").
                OnCompletion(onComplete).
                Build();
        }
