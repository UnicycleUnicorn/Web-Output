# Web Output
This project has just begun, items are still a massive WIP

## Goal
The goal of this project, Web Output, is to serve as a simple method to send command results from a terminal to a web interface. This way it may be more easily viewed, copied, and sent to others.
The following items define some end goals of this project:

- Open Source
- Easy access with no need for downloadable tools
- Simple to use
- Re-usable links
- Encrypted network traffic
- Ability to lock output through credentials
- No user accounts
- Easily self-hostable (customizable)
- Containerizable

## How to use (Note, the link is based off local hosting currently)
### Windows Command Prompt
```dir | curl -X POST https://localhost:7019/Data --data-binary @-```


**Special thanks to https://seashells.io/ for inspiring this project**
