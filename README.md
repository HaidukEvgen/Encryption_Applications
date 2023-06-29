# Encryption_Applications
These are Windows forms applications written in C# for file encryption and digital signing using various algorithms and types of cryptosystems.

## LFSR
This is a Stream Cipher Cryptosystem based on a 36-bit LFSR (Linear linear feedback shift register).

You can use it to encrypt small files, and no one will be able to open them until they decrypt the file using this program and the same key as you did.

LFSR generates a pseudo-random sequence that has the same length as the file in bits, and then the bits of the file are XORed with the sequence bits. To decrypt the file, you need to use the same initial state for the LFSR so that it generates the same sequence, and then it can be XORed again to get the original file.

![image](https://github.com/HaidukEvgen/Encryption_Applications/assets/92396956/33163041-5cd6-48ef-9ea3-101a370745ea)

## RSA
RSA (Rivest–Shamir–Adleman) is a public-key cryptosystem, one of the oldest, that is widely used for secure data transmission. In a public-key cryptosystem, the encryption key is public and distinct from the decryption key, which is kept secret (private). An RSA user creates and publishes a public key based on two large prime numbers, along with an auxiliary value. The prime numbers are kept secret. Messages can be encrypted by anyone, via the public key, but can only be decoded by someone who knows the prime numbers.

![image](https://github.com/HaidukEvgen/Encryption_Applications/assets/92396956/d4eeb6c1-6fc5-4eb5-8678-cd9161e95928)

## DSA Digital signature

The DSA works in the framework of public-key cryptosystems and is based on the algebraic properties of modular exponentiation, together with the discrete logarithm problem, which is considered to be computationally intractable. The algorithm uses a key pair consisting of a public key and a private key. The private key is used to generate a digital signature for a message, and such a signature can be verified by using the signer's corresponding public key. The digital signature provides message authentication (the receiver can verify the origin of the message), integrity (the receiver can verify that the message has not been modified since it was signed) and non-repudiation (the sender cannot falsely claim that they have not signed the message).

![image](https://github.com/HaidukEvgen/Encryption_Applications/assets/92396956/a6993b1d-222d-42b8-b4cb-4bbb6858394b)
![image](https://github.com/HaidukEvgen/Encryption_Applications/assets/92396956/f20e0c27-6064-4784-bb2c-40b979eb28e4)
![image](https://github.com/HaidukEvgen/Encryption_Applications/assets/92396956/128aaf58-a7c2-4ede-a61e-c8dcd7f57324)

