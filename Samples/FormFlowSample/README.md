
# FormFlow Samples

#### Important Files:
1. /Controllers/MessageController.cs
2. /Models/BugReport.cs

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
