# Microsoft Bot Framework V3 Samples

#### What is a BOT?
Application that performs an automated task.

#### What is a channel?
Channel is medium in which user communicates with Bot.

#### What are different channels available?
Skype, Facebook messenger, MS teams, slack, SMS

#### How bot interacts with channel?
Channel exposes API. 
It send messages out when user types in. 
It receives messages whenever it gets reply.
Bot exposes an API.
Bot receives messages from user through this API.

#### What is connector Service?
It sits between bot and channel. It translates channel json into activity.

#### What is activity?
Activity is the object used to communicate between a user and a bot.

#### What are Dialogs?
Dialog provide way to manage conversation with user

#### What are different ways to save Bot state?
1. In Memory storage (only for Dev)
2. Azure Blob storage
3. Azure Cosmos DB

#### What are the type of Bot data?
1. User Data
2. Conversation Data
3. Private Conversation Data

#### What are the different type of activity?
1. Message
2. DeleteUserData
3. ConversationUpdate
4. ContatRelationUpdate
5. Typing
6. Ping

