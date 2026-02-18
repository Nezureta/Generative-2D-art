#version 330 core
out vec4 FragColor;
in vec3 ourColor;

uniform float time;

void main() {
    // Optional: Keep the sin pulse for the whole rainbow
    float pulse = sin(time) * 0.5 + 0.5;
    FragColor = vec4(ourColor * pulse, 1.0);
}