This is the NOMP Desktop App* NOMP Desktop App (Windows & OSX)
   To knock down the barrier to entry for mining for those not tech-oriented, a better "Get Started" guide is being
created. Rather than the help page being confusing for non-techies (when most people see a black command prompt screen they close the browser), a simple *Download NOMP Desktop App to get started mining immediately* link will be displayed for your. 
   * Currently this app is being designed for Windows and OSX using [C#/Mono/Gtk#](http://www.mono-project.com/GtkSharp) (linux don't need this app). Javascript will detect platform to display the correct download link.
   * This app will have its own repo and setup instructions so NOMP pool operators can choose to set it up for their pool.
   
There will be a nomp.ini
file paired with the executable which the pool operator configures to user their NOMP pool's API url. When the NOMP portal
initiates creates a zip for each platform with the nomp.ini inside. When user's download the app, it auto-connects to the
NOMP pool API to get available coins along with the version-byte for each coin so the app can securely generate a local private
key and valid address to mine with. The app pill prompt printing the private key to paper and also enforce a
STRONG (uncrackable) password encryption on the file.
The app will scan their system to get the appropriate mining software - run in background - parse the gibberish (to a noob) output
into something that makes sense. It will also prompt them to download the coins wallet software and import their private key.
When using the app they can choose a unique username that is used
with stratum authentication like "zone117x.mfsm1ckZKTTjDz94KonZZsbZnAbm1UV4BF", so that on a NOMP mobile app, a user can
enter in the NOMP pool and their username in order to see how their mining rig is doing since the API will report stats
back for the address such as hashrate and balance.