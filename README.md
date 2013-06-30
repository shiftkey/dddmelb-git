# Thinking Like A Git

## Setup your environment

Feel free to do this before you show up, but I'll run through it quickly on the day (it's really quick)

## Coloured Diffs Are Freaking Rad

Just check that these values are set to auto on your machine:

    git config color.status
    git config color.diff

If you don't see a value (or it's not `auto`) just run these commands

    git config color.status auto --global
    git config color.diff auto --global

Because these colours make a lot of difference.

### A better log output 

You don't need a GUI - well, that's my opinion anyway.

Source: [A better "git log"](https://coderwall.com/p/euwpig).

This is the vanilla log command for git.

    `git log`

It's actually really extensible (I've used it to identify all committers in a repo when setting up some service) but the defaults are just hideous.

So let's make a similar command that gives us some more context.

In your terminal (whatever flavour how have) run this command:

    git config --global alias.lg "log --color --graph --pretty=format:'%Cred%h%Creset -%C(yellow)%d%Creset %s %Cgreen(%cr) %C(bold blue)<%an>%Creset' --abbrev-commit"

Now this gives you:

 - the short hash
 - all branches associated with this commit
 - relative timestamp
 - commit message

This also integrates with the default `git log` parameters, so you can do things like this:

    git log -p

and combine the nice message with the contents of each commit.

### Some quick shortcuts

I find myself using some quick shortcuts for checking the workspace status and differences.

Feel free to add them to your environment:

    git config --global alias.s "status"
    git config --global alias.d "diff"
    git config --global alias.ds "diff --staged"