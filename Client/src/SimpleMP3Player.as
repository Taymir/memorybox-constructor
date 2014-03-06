package {
    import flash.events.*;
    import flash.media.Sound;
    import flash.media.SoundChannel;
    import flash.media.SoundTransform;
    import flash.net.URLRequest;     

    public class SimpleMP3Player {
    
    public var loop:Boolean = true;
    
    // Sound Channel to monitor
    private var song:SoundChannel;     

    // Request object for obtaining mp3
    private var request:URLRequest;

    // Pause state management
	private var paused:Boolean = true;     

	// Stopped state management
	private var stopped:Boolean = false;     

	// Retains what position the song was in
	// when it was paused, so we can go back to
	// the same position when we hit play again.
	private var position:Number;     

	// Sound... Factory for initializing our song.
    private var soundFactory:Sound;     

    public function SimpleMP3Player() {
    }
    
    private function getLoops() : int
    {
	    if(this.loop)
	    	return int.MAX_VALUE;
	    	
    	return 0;
    }

	private var lastMP3 : String = "";

	// Play MP3 at specified index in songURLs array.
	public function playMP3(mp3: String):void 
	{
		if(mp3 == "")
			return;
			
		if(mp3 == lastMP3 && !stopped)
			return;
		
		var volume : int = 1;
		if(song)
		{
			song.stop();
			volume = song.soundTransform.volume;
		}
		
	    stopped = false;
	    paused = false;
	    position = 0;
	    var request:URLRequest =
	        new URLRequest(mp3);
        lastMP3 = mp3;
	    soundFactory = new Sound();
	    soundFactory.load(request);

	    song = soundFactory.play(0, getLoops(), new SoundTransform(volume));
	}   

	// Pause current song, or play song if already paused.
	// Setting playButton label such that any GUI button
	// that is attached will change with play or pause.
	public function pause():void {
	    if (!stopped) {
	        if (!paused) {
	    	    paused = true;
		    position = song.position;
		    song.stop();
	        } else {
		    paused = false;
		    song = soundFactory.play(position);
	        }
	    } else {
	        song = soundFactory.play();
	    }
    }     

	// Stop current song
	public function stop():void {
		stopped = true;
		if(song)
			song.stop();
		position = 0;
	}     
	
    public function mute():void {
    	if(!song)
    		return;
        // Mute the channel, but only if it not muted
        if (song.soundTransform.volume !=0 ) {
            song.soundTransform = new SoundTransform(0);
        } else {
            song.soundTransform = new SoundTransform(1);
        }
    }
    }
}