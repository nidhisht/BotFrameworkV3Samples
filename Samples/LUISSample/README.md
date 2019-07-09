# LUIS Sample

### What is LUIS
It is Microsoft cognitive service for natural language processing

### Expansion of LUIS?
Language Understanding Intelligent Service

### How does LUIS work?
It utilizes interactive machine learning

### LUIS Framework aspects
1. Intents
2. Entities
3. Utterances

### Intents (*VERB*)
Identifies what action you want the bot to take.

### Entity (*NOUN*)
Identifies what things your bot taking action on
Entities are shared across the intents

### Utterances (*Sentences*)
Sentences uses intents and entities

### What are types of entities?
1. Simple
2. Hierarchical
3. Composite
4. List
5. Regex
6. Prebuilt

## Important Files:
1. /Controllers/MessageController.cs
2. /Models/BugReport.cs
3. /Dialogs/LUISDialog.cs

#### What to look in /Controllers/MessagesController.cs?
        internal static IDialog<BugReport> MakeLuisDialog()
        {
            return Chain.From(() => new LUISDialog(BugReport.BuildForm));
        }
        
 #### What to look in /Models/BugReport.cs?
         public static IForm<BugReport> BuildForm()
        {
            return new FormBuilder<BugReport>().
                Message("**Create Bug Report**").
                OnCompletion(onComplete).
                Build();
        }
        
  #### What to look in /Dialogs/LUISDialog.cs?
  Entire class
