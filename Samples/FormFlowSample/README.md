# Form Flow Samples

#### Why Form Flow?
Form Flow helps to reduce effort to build bot.

#### How Form Flow works?
Form Flow uses POCO* model and creates series of questions from it.

## Important components of Form Flow:
1. Attributes
2. Custom business block
3. Form Builder class

#### What are the different types of attributes
1. Describe
2. Prompt
3. Pattern
4. Numeric
5. Term

#### Advantage:
1. Form Flow allow user to go back and change the answer (allow navigation between steps)
2. Intelligent enough to understand 1 and one
3. Intelligent enough to understand now or tomorrow as datetime
4. Allow to bind user answers to object model

## Important Files:
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


### Reference
http://aihelpwebsite.com/Blog/EntryId/8/Introduction-To-FormFlow-With-The-Microsoft-Bot-Framework

* POCO - Plain Old CLR Object
