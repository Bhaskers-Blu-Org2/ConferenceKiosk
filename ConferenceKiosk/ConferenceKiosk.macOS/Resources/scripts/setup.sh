#!/bin/sh
PROJECT_NAME="ConferenceVision"
PROJECT_PATH="$HOME/Documents/GitHub/$PROJECT_NAME"
DESKTOP_PATH="$HOME/Desktop"

echo "Copying project to desktop"
cp -R $PROJECT_PATH $DESKTOP_PATH/$PROJECT_NAME

echo "Opening solution..."
open -g $DESKTOP_PATH/$PROJECT_NAME/$PROJECT_NAME.sln -a "Visual Studio.app"