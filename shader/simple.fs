#version 330 core

uniform vec4 color;
uniform sampler2D tex;
uniform sampler2D tex2;

in vec2 texCoord;

out vec4 fragColor;

void main()
{
    fragColor = texture(tex, texCoord) * 0.8 + texture(tex2, texCoord) * 0.2;
}