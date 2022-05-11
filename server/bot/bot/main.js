const { Client, Intents } = require('discord.js');
import fetch from 'node-fetch'

const client = new Client({
    intents: [
      Intents.FLAGS.GUILDS,
      Intents.FLAGS.GUILD_MEMBERS,
      Intents.FLAGS.GUILD_BANS,
      Intents.FLAGS.GUILD_EMOJIS_AND_STICKERS,
      Intents.FLAGS.GUILD_INTEGRATIONS,
      Intents.FLAGS.GUILD_WEBHOOKS,
      Intents.FLAGS.GUILD_INVITES,
      Intents.FLAGS.GUILD_VOICE_STATES,
      Intents.FLAGS.GUILD_PRESENCES,
      Intents.FLAGS.GUILD_MESSAGES,
      Intents.FLAGS.GUILD_MESSAGE_REACTIONS,
      Intents.FLAGS.GUILD_MESSAGE_TYPING,
    ],
  });

client.once('ready', async () => {
    console.log('Online')
    const guild = client.guilds.cache.get(''); 
    let role = guild.roles.cache.find(r => r.name === "Muted")
    console.log(`Found ${role.name}`);
    
    const user = await guild.members.fetch('')
        .catch(console.error);
    while(true) {
      fetch('data.txt')
        .then(response => response.text())
        .then(text => console.log(text))
      if (text == 0)
          await user.roles.add(role).catch(console.error)
      else if (text == 1)
          await user.roles.remove(role).catch(console.error)
    }
})

client.login('')
