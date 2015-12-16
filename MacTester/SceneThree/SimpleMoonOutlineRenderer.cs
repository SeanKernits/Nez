﻿using System;
using Nez;
using Nez.Sprites;


namespace MacTester
{
	public class SimpleMoonOutlineRenderer : RenderableComponent
	{
		public override float width
		{
			get { return _sprite.width; }
		}

		public override float height
		{
			get { return _sprite.height; }
		}


		Sprite _sprite;


		public SimpleMoonOutlineRenderer( Sprite sprite )
		{
			_sprite = sprite;
			_sprite.enabled = false;
		}


		public override void render( Graphics graphics, Camera camera )
		{
			_sprite.drawOutline( graphics, camera, 3 );
			_sprite.render( graphics, camera );
		}
	}
}

