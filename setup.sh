git config --global alias.lg "log --color --graph --pretty=format:'%Cred%h%Creset -%C(yellow)%d%Creset %s %Cgreen(%cr) %C(bold blue)<%an>%Creset' --abbrev-commit"
git config --global alias.s "status"
git config --global alias.d "diff"
git config --global alias.ds "diff --staged"
git config --global alias.now "rev-parse --short HEAD"

git config color.status auto --global
git config color.diff auto --global