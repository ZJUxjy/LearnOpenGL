#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec3 ourpos;
void main()
{
    FragColor = vec4(ourpos, 1.0f);
}