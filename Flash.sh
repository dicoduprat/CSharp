
#!/bin/bash
# build diretories
mkdir ~/Downloads/chrome
mkdir ~/development
mkdir ~/development/flash

# install xclip and git
sudo apt update
sudo apt install xclip
sudo apt install git

# configure git and github
echo 'Enter your git username:'
read gitUsername
git config --global user.name "$gitUsername"
echo 'Enter yout git email:'
read gitEmail
git config --global user.email "$gitEmail"
ssh-keygen -t rsa -b 4096 -C "$gitEmail"
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_rsa
xclip -selection clipboard < ~/.ssh/id_rsa.pub
echo 'Paste the already copied ssh key to your github account. When
finished, press enter:'
read randomVar

# clone all repositories
cd ~/development/flash
git clone git@github.com:flash-tecnologia/admin-server.git
git clone git@github.com:flash-tecnologia/admin-web.git
git clone git@github.com:flash-tecnologia/company-server.git
git clone git@github.com:flash-tecnologia/flamingo-ui.git
git clone git@github.com:flash-tecnologia/flash-modules.git
git clone git@github.com:flash-tecnologia/flash-services.git
git clone git@github.com:flash-tecnologia/web-front.git
git clone git@github.com:flash-tecnologia/finance-server.git
git clone git@github.com:flash-tecnologia/person-server.git
git clone git@github.com:flash-tecnologia/flash-app.git
git clone git@github.com:flash-tecnologia/merchant-server-flash.git
cd ~/development

# install all node related packages

curl -sL https://deb.nodesource.com/setup_12.x | sudo -E bash -
sudo apt install nodejs
sudo npm i -g yarn
npm i -g ngrok ##talvez nao funcione 

# configure AWS
sudo apt install python3
sudo apt install python3-pip
sudo apt install awscli
sudo apt install jq
