import streamDeck from "@elgato/streamdeck";
import { Toggle } from "./actions/toggle";

streamDeck.actions.registerAction(new Toggle());
streamDeck.connect();