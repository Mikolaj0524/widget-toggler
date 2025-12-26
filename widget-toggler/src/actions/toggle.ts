import { action, KeyDownEvent, SingletonAction } from "@elgato/streamdeck";
import { execFile } from "child_process";

@action({ UUID: "fun.mikolaj0524.widget-toggler.toggler" })
export class Toggle extends SingletonAction<{}> {

    override async onKeyDown(ev: KeyDownEvent<{}>): Promise<void> {
        try {
            execFile("./bin/Toggler.exe");
        }
        catch (err) {
            console.error(err);
        }
    }
}
