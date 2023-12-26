def encode_file(input_file, output_file, key, alternate=False):
    with open(input_file, 'r', encoding='utf-16') as file:
        text = file.read()
        encoded_text = ''
        for i in range(len(text)):
            if alternate and i % 2 == 0:
                encoded_text += text[i]
            else:
                encoded_text += chr(ord(text[i]) + key)
    
    with open(output_file, 'w', encoding='utf-16') as file:
        file.write(encoded_text)

def decode_file(input_file, output_file, key, alternate=False):
    with open(input_file, 'r', encoding='utf-16') as file:
        text = file.read()
        decoded_text = ''
        for i in range(len(text)):
            if alternate and i % 2 == 0:
                decoded_text += text[i]
            else:
                decoded_text += chr(ord(text[i]) - key)
    
    with open(output_file, 'w', encoding='utf-16') as file:
        file.write(decoded_text)

# Пример использования
encode_file('input.txt', 'encoded.txt', 3, True)
decode_file('encoded.txt', 'decoded.txt', 3, True)
