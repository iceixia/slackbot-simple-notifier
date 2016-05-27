# slackbot-simple-notifier
a very simple libary for posting messages to slackbot

#Usage

```
using confluence.slackbot;

public static bool sendSomething
{
  notifier.config cfg = new notifier.config();
  
  cfg.channel = "general";
  cfg.team = "your slack team here";
  cfg.token = "your slackbot token here";
  message = "sample message";
  
  bool status = notifer.send(cfg, message);
  
  return status;
}

// returns "true" if successfull "false" on failure

```

Any isues let me know via e-mail dan[at]confluence-software.co.uk

#License

Just do whatever you want with it. No need to credit me either.
